namespace Application.Interfaces
{
    //Clean code da factory design pattern olarak geçiyor. IOC sisteminin manual yazýlmýþ hali. Bu yapýyý global yapýda UnitOfWork olarak tanýmlayabiliriz. Factory Design Pattern yapýsýdýr.
    //Veritabaný olmayan yapýlarda UnitOfWork yapýsýný bu þeklde oluþturuyoruz.
    public interface IPaymentProviderFactory
    {
        IPaymentProvider GetProvider(string providerName);
    }
}

