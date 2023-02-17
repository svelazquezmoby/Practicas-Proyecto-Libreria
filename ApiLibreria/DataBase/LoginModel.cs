using System;
using System.Collections.Generic;

namespace DataBase;

public partial class LoginModel
{
    public int LoginId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
