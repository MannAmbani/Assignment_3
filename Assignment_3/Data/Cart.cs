using System;
using System.Collections.Generic;

namespace Assignment_3.Data;

public partial class Cart
{
    public int CartId { get; set; }

    public int ProductId { get; set; }

    public int UserId { get; set; }

    public int Quantities { get; set; }
}
