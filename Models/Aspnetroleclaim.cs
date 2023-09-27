using System;
using System.Collections.Generic;

namespace Capstone_Olapp.Models;

public partial class Aspnetroleclaim
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public virtual Aspnetrole Role { get; set; } = null!;
}
