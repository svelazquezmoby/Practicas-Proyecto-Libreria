using System;
using System.Collections.Generic;

namespace DataBase;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Editorial { get; set; } = null!;

    public int? UserIdUser { get; set; }
}
