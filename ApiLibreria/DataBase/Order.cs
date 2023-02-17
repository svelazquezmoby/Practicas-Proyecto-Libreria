using System;
using System.Collections.Generic;

namespace DataBase;

public partial class Order
{
    public int OrderId { get; set; }

    public string Detail { get; set; } = null!;

    public DateTime DateStart { get; set; }

    public DateTime DateFinish { get; set; }

    public int IdUser { get; set; }

    public int IdBook { get; set; }
}
