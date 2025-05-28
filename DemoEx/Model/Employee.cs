using System;
using System.Collections.Generic;

namespace DemoEx.Model;

public partial class Employee
{
    public int IdEmployee { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MidleName { get; set; }

    public DateOnly BirthDay { get; set; }

    public string Bank { get; set; } = null!;

    public bool Married { get; set; }

    public string Health { get; set; } = null!;

    public virtual ICollection<Bid> Bids { get; set; } = new List<Bid>();
}
