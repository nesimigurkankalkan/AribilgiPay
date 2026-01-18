using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPaymentService
    {
        Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest request); //Ödeme İslemi Yap
        Task<RefundResponse> ProcessRefundAsync(RefundRequest request); //Ödemeyi Geri Alma
        Task<PaymentResponse> GetPaymentStatusAsync(string transactionId, string provider); //Statusu Görmek İçin
    }
}
