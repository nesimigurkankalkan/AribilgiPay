using Application.DTOs;
using Application.Interfaces;
using Domain.Enums;

namespace Infrastructure.Providers
{
    public class MockPayProvider : IPaymentProvider
    {
        public string ProviderName => "MockPay";
        public async Task<PaymentResponse> GetPaymentStatusAsync(string transactionId)
        {
            // Durum Kontrol İşlemi Yapılıyor.
            await Task.Delay(100);

            return new PaymentResponse
            {
                Status = PaymentStatus.Completed,
                Success = true,
                TransactionId = transactionId
            };
        }

        public async Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest request)
        {
            // Ödeme İşlemi Yapılıyor.
            await Task.Delay(100);

            return new PaymentResponse
            {
                Status = PaymentStatus.Pending,
                Success = true,
                TransactionId = $"MP_{Guid.NewGuid()}",
                MetaData = new Dictionary<string, object>
                {
                    ["provider"] = "MockPay",
                    ["paymentMethod"] = "redirect",
                    ["amount"] = request.Amount,
                    ["uniqueId"] = request.OrderId,
                    ["currenctCode"] = request.Currency
                },
                PaymentUrl = $"https://localhost:8000/checkoutnow?token=SEC-{Guid.NewGuid()}"
            };
        }


        public async Task<RefundResponse> ProcessRefundAsync(RefundRequest request)
        {
            // İade İşlemi Yapılıyor.
            await Task.Delay(100);

            return new RefundResponse
            {
                Success = request.Amount > 0,
                RefundId = $"MP_R_{Guid.NewGuid()}",
                RefundedAmount = request.Amount ?? 0
            };
        }
    }
}
