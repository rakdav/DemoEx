using System;
using System.Collections.Generic;

namespace DemoEx.Model;

public partial class Material
{
    public int IdMaterial { get; set; }

    public string Type { get; set; } = null!;

    public string NameMaterial { get; set; } = null!;

    public int IdSuppleir { get; set; }

    public int CountBox { get; set; }

    public string Unit { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Foto { get; set; } = null!;

    public decimal Price { get; set; }

    public int Count { get; set; }

    public int MinCount { get; set; }

    public virtual ICollection<Productmaterial> Productmaterials { get; set; } = new List<Productmaterial>();
}
