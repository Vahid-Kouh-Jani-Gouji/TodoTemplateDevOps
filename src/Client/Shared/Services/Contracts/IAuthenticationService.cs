using TodoTemplateDevOps.Shared.Dtos.Account;

namespace TodoTemplateDevOps.Client.Shared.Services.Contracts;

public interface IAuthenticationService
{
    Task SignIn(SignInRequestDto dto);

    Task SignOut();
}
