namespace AuthService;

public interface IAuctionUser
{
    Task<string> SignUpUser(RegisterUserDto registerUserDto);
    Task<LoginResponseDto> SignInUser(LoginRequestDto loginRequestDto);
    Task<List<AuctionUserDto>> GetAllUsers();
    Task<AuctionUserDto> GetOneUser(Guid Id);

}
