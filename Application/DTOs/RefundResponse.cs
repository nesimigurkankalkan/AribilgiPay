namespace Application.DTOs
{
    public record RefundResponse
    {
        public bool Success { get; init; }
        public string? RefundId { get; init; }
        public string? ErrorMessage { get; init; }
        public decimal RefundedAmount { get; init; }
    }
}
