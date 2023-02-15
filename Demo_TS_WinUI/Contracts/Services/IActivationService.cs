namespace Demo_TS_WinUI.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
