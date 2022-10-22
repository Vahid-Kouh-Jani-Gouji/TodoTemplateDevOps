using TodoTemplateDevOps.Server.Api.Models.Account;
using TodoTemplateDevOps.Shared.Dtos.Account;

namespace TodoTemplateDevOps.Server.Api.Services.Contracts;

public interface IJwtService
{
    Task<SignInResponseDto> GenerateToken(User user);
}
