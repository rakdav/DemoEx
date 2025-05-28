using System;
using System.Collections.Generic;

namespace DemoEx.Model;

public partial class TypeProduct
{
    public string TypeName { get; set; } = null!;

    public float Koef { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
