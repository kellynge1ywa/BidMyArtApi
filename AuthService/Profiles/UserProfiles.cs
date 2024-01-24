using AutoMapper;

namespace AuthService;

public class UserProfiles:Profile
{
    public UserProfiles()
    {
        CreateMap<RegisterUserDto, AuctionUser>().ForMember(dest=>dest.UserName, src=>src.MapFrom(e=>e.Email));
        CreateMap<AuctionUserDto, AuctionUser>().ReverseMap();
    }

}
