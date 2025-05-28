using System;
using System.Collections.Generic;

namespace DemoEx.Model;

public partial class Productmaterial
{
    public int Id { get; set; }

    public int IdMaterial { get; set; }

    public int Count { get; set; }

    public virtual Material IdMaterialNavigation { get; set; } = null!;
}
