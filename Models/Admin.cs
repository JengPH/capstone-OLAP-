using System;
using System.Collections.Generic;

namespace Capstone_Olapp.Models;

public partial class Admin
{
    public int AdId { get; set; }

    public string AdName { get; set; } = null!;

    public string AdPassword { get; set; } = null!;
}
