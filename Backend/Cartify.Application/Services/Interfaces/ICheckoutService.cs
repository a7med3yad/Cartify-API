using Cartify.Domain.Models;

namespace Cartify.Application.Services.Interfaces
{
    public interface ICheckoutService
    {
        Task<TblOrder> ProcessCheckoutAsync(CheckoutDto checkoutData);
    }

    public class CheckoutDto
    {
        public int UserId { get; set; }
        public List<CartItemDto> CartItems { get; set; }
        public ShippingInfoDto ShippingInfo { get; set; }
        public PaymentInfoDto PaymentInfo { get; set; }
    }

    public class CartItemDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class ShippingInfoDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }

    public class PaymentInfoDto
    {
        public string PaymentMethod { get; set; } // "card", "paypal", "cod"
        public string CardNumber { get; set; }
        public string CardHolder { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }
    }
}