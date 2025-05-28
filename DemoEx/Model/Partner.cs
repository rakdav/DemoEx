using System;
using System.Collections.Generic;

namespace DemoEx.Model;

public partial class Partner
{
    public string NameCompany { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Director { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string UrAddress { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public int Reiting { get; set; }

    public string? Logo { get; set; }

    public virtual ICollection<Place> Places { get; set; } = new List<Place>();
}
