using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TranGiaBao_0230_lab02.Models;

public class Order
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
    public string BuyerName { get; set; } // Added field for buyer's name
    public string PhoneNumber { get; set; } // Added field for phone number
    public string ShippingAddress { get; set; }
    public string Notes { get; set; }
    [ForeignKey("UserId")]
    [ValidateNever]
    public ApplicationUser ApplicationUser { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
}