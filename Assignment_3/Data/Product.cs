using System;
using System.Collections.Generic;

namespace Assignment_3.Data;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Image { get; set; } = null!;

    public double Pricing { get; set; }

    public double ShippingCost { get; set; }
}
