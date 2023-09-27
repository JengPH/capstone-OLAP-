using System;
using System.Collections.Generic;

namespace Capstone_Olapp.Models;

public partial class Aspnetusertoken
{
    public int UserId { get; set; }

    public string LoginProvider { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public virtual Aspnetuser User { get; set; } = null!;
}
