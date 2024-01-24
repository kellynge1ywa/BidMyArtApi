
namespace AuthService;

public class AuctionUserServices : IAuctionUser
{
    
    public Task<List<AuctionUserDto>> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public Task<AuctionUserDto> GetOneUser(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<LoginResponseDto> SignInUser(LoginRequestDto loginRequestDto)
    {
        throw new NotImplementedException();
    }

    public Task<string> SignUpUser(RegisterUserDto registerUserDto)
    {
        throw new NotImplementedException();
    }
}
