using System;
using System.Collections.Generic;

namespace DemoEx.Model;

public partial class Place
{
    public int IdPlace { get; set; }

    public string Address { get; set; } = null!;

    public string NameCompany { get; set; } = null!;

    public virtual Partner NameCompanyNavigation { get; set; } = null!;
}
