namespace SymbolSource.Gateway.Core
{
    public interface IGatewayConfiguration
    {
        string GatewayLogin { get; }
        string GatewayPassword { get; }
        string PublicLogin { get; }
        string PublicPassword { get; }
    }

    public interface IGatewayConfigurationFactory
    {
        IGatewayConfiguration Create(string company);
    }
}