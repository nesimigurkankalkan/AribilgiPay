using Application.Interfaces;
using Infrastructure.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Factories
{
    // IServiceProvider: builder.Services alanında tamınlayacağımız, 'MockPayProvider', 'PayPalProvider' gibi servisleri okur.
    public class PaymentProviderFactory(IServiceProvider serviceProvider) : IPaymentProviderFactory
    {
        public IPaymentProvider GetProvider(string providerName)
        {
            return providerName.ToLower() switch
            {
                "mockpay" => serviceProvider.GetRequiredService<MockPayProvider>(),
                _ => throw new ArgumentException($"Payment provider '{providerName}' not supported!")
            };
        }
    }
}
