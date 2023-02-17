using System;
using System.Collections.Generic;

namespace DataBase;

public partial class User
{
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public int OrderId { get; set; }
}
