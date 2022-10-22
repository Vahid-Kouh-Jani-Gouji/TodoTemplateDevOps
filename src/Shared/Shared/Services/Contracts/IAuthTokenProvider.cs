namespace TodoTemplateDevOps.Shared.Services.Contracts;

public interface IAuthTokenProvider
{
    Task<string?> GetAcccessToken();
}
