using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    //Reuqests:
    public record PaymentRequest
    {
        [Required]
        public string Provider { get; init; } = default!;

        [Required, Range(0.01, double.MaxValue)]
        public decimal Amount { get; init; }

        [Required]
        public string Currency { get; set; } = "TRY";

        [Required]
        public string OrderId { get; init; } = default!;

        public string? Description { get; init; }
        public Dictionary<string, object>? MetaData { get; init; } // Ekbilgi
    }
}
