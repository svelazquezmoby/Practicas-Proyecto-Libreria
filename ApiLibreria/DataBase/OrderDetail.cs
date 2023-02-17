using System;
using System.Collections.Generic;

namespace DataBase;

public partial class OrderDetail
{
    public int DetailId { get; set; }

    public string Detail { get; set; } = null!;

    public int OrderId { get; set; }
}
