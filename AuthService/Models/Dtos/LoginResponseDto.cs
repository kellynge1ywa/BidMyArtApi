namespace AuthService;

public class LoginResponseDto
{
     public string Token {get;set;}="";
    public AuctionUser User {get;set;}=default!;

}
