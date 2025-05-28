using System;
using System.Collections.Generic;

namespace DemoEx.Model;

public partial class Bid
{
    public int IdBid { get; set; }

    public int? IdPartner { get; set; }

    public int? IdEmployee { get; set; }

    public virtual Employee? IdEmployeeNavigation { get; set; }
}
