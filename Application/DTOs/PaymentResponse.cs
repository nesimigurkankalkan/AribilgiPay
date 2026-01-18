using Domain.Enums;

namespace Application.DTOs
{
    public record PaymentResponse
    {
        public bool Success { get; init; }
        public PaymentStatus Status { get; init; }
        public string? TransactionId { get; init; }
        public string? PaymentUrl { get; init; } //Ödeme sayfası linki, bununla gidip karsı taraftan sana ekran açıcak url vercek.
        public string? ErrorMessage { get; init; }
        public Dictionary<string, object>? MetaData { get; init; }
    }
}
