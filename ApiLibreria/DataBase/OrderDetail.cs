using System;
using System.Collections.Generic;

namespace DataBase;

public partial class OrderDetail
{
    public int DetailId { get; set; }

    public string Detail { get; set; } = null!;s

    public int OrderId { get; set; }
}
