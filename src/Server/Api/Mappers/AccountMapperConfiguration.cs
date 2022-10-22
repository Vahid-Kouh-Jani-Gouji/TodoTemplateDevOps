using TodoTemplateDevOps.Server.Api.Models.Account;
using TodoTemplateDevOps.Shared.Dtos.Account;

namespace TodoTemplateDevOps.Server.Api.Mappers;

public class AccountMapperConfiguration : Profile
{
    public AccountMapperConfiguration()
    {
        CreateMap<Role, RoleDto>().ReverseMap();

        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, EditUserDto>().ReverseMap();
        CreateMap<User, SignUpRequestDto>()
            .ReverseMap();
    }
}
