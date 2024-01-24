namespace AuthService;

public interface Ijwt
{
    string GenerateToken(AuctionUser auctionUser, IEnumerable<string> Roles);
}
