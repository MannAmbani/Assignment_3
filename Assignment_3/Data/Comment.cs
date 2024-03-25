using System;
using System.Collections.Generic;

namespace Assignment_3.Data;

public partial class Comment
{
    public int CommentId { get; set; }

    public int ProductId { get; set; }

    public int UserId { get; set; }

    public double Rating { get; set; }

    public string Images { get; set; } = null!;

    public string CommentText { get; set; } = null!;
}
