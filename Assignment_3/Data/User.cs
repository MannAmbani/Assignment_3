using System;
using System.Collections.Generic;

namespace Assignment_3.Data;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string PurchaseHistory { get; set; } = null!;

    public string ShippingAddress { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
