
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace AuthService;

public class JwtServices : Ijwt
{
    private readonly JwtOptions _jwtOptions;
    public JwtServices(IOptions<JwtOptions> options)
    {
        _jwtOptions=options.Value;
    }
    public string GenerateToken(AuctionUser auctionUser, IEnumerable<string> Roles)
    {
        var mykey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey));
        var cred=new SigningCredentials(mykey, SecurityAlgorithms.HmacSha256);

        //payload
        List<Claim> claims=new List<Claim>();
        claims.Add(new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Sub,auctionUser.Id.ToString()));
        //Adding a list of roles
        claims.AddRange(Roles.Select(k=>new Claim(ClaimTypes.Role, k)));

        //token
        var tokendescriptor=new SecurityTokenDescriptor(){
            Issuer=_jwtOptions.Issuer,
            Audience=_jwtOptions.Audience,
            Expires=DateTime.UtcNow.AddHours(3),
            Subject=new ClaimsIdentity(claims),
            SigningCredentials=cred
        };
        var token =new JwtSecurityTokenHandler().CreateToken(tokendescriptor);
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
