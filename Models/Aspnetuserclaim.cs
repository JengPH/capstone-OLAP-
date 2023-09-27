﻿using System;
using System.Collections.Generic;

namespace Capstone_Olapp.Models;

public partial class Aspnetuserclaim
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public virtual Aspnetuser User { get; set; } = null!;
}
