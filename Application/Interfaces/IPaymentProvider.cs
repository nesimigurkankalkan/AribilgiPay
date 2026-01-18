using Application.DTOs;
using System.ComponentModel.DataAnnotations;

namespace Application.Interfaces
{
    //Entities & Factories:
    public interface IPaymentProvider
    {
        string ProviderName { get; }
        Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest request);
        Task<RefundResponse> ProcessRefundAsync(RefundRequest request);
        Task<PaymentResponse> GetPaymentStatusAsync(string transactionId);

    }

    
}
