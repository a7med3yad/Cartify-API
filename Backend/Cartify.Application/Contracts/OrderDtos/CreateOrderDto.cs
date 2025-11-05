using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cartify.Application.Contracts.OrderDtos
{
    public class CreateOrderDto
    {
        [Required]
        public int StoreId { get; set; }

        [Required]
        public int PaymentTypeId { get; set; }

        [Required]
        public int ShipmentMethodId { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "At least one order item is required")]
        public List<CreateOrderItemDto> OrderItems { get; set; } = new List<CreateOrderItemDto>();

        public decimal? Tax { get; set; }
    }

    public class CreateOrderItemDto
    {
        [Required]
        public int ProductDetailId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }
    }
}

