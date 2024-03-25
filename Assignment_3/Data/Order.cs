using System;
using System.Collections.Generic;

namespace Assignment_3.Data;

public partial class Order
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public double TotalCost { get; set; }

    public string ShippingAddress { get; set; } = null!;

    public string PaymentMethod { get; set; } = null!;

    public string Status { get; set; } = null!;
}
