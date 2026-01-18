using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/payments")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        [HttpGet("{transactionId}/status")]
        public async Task<IResult> GetStatus(string transactionId, [FromQuery] string provider, [FromServices] IPaymentService paymentService)
        {
            try
            {
                var result = await paymentService.GetPaymentStatusAsync(transactionId, provider);
                return Results.Ok(result);
            }
            catch (ArgumentException ex) //Arguman eksiği, eksik data var demektir.
            {
                return Results.BadRequest(new { error = ex.Message }); //400
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message); //500
            }
        }

        [HttpPost, Route("process")]
        public async Task<IResult> PaymentProcess([FromBody] PaymentRequest request, [FromServices] IPaymentService paymentService)
        {
            try
            {
                var result = await paymentService.ProcessPaymentAsync(request);
                return Results.Ok(result); //200
            }
            catch (ArgumentException ex) //Arguman eksiği, eksik data var demektir.
            { 
                return Results.BadRequest(new { error = ex.Message}); //400
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message); //500
            }
        
        }
        [HttpPost, Route("refund")]
        public async Task<IResult> RefundProcess([FromBody] RefundRequest request, [FromServices] IPaymentService paymentService)
        {
            try
            {
                var result = await paymentService.ProcessRefundAsync(request);
                return Results.Ok(result); //200
            }
            catch (ArgumentException ex) //Arguman eksiği, eksik data var demektir.
            { 
                return Results.BadRequest(new { error = ex.Message}); //400
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message); //500
            }
        
        }
    }
}
