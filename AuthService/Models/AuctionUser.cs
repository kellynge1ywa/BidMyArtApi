using Microsoft.AspNetCore.Identity;

namespace AuthService;

public class AuctionUser: IdentityUser
{
    public string Fullname {get;set;} ="";
    public DateTime DOB {get;set;}


}
