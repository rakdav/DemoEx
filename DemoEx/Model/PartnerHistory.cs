using System;
using System.Collections.Generic;

namespace DemoEx.Model;

public partial class PartnerHistory
{
    public string? NameProduct { get; set; }

    public string? NameCompany { get; set; }

    public int? Count { get; set; }

    public DateOnly? Date { get; set; }

    public virtual Partner? NameCompanyNavigation { get; set; }

    public virtual Product? NameProductNavigation { get; set; }
}
