using System;
using System.Collections.Generic;

namespace DemoEx.Model;

public partial class Product
{
    public string NameProduct { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Articul { get; set; }

    public string? Description { get; set; }

    public string? Foto { get; set; }

    public decimal MinPrice { get; set; }

    public float? Length { get; set; }

    public float? Width { get; set; }

    public float? Height { get; set; }

    public decimal? WeightWithoutBox { get; set; }

    public decimal? Weight { get; set; }

    public string? Skan { get; set; }

    public int? Standart { get; set; }

    public DateOnly? Time { get; set; }

    public decimal? Cost { get; set; }

    public int? CehNumber { get; set; }

    public int? CountEmp { get; set; }

    public virtual TypeProduct TypeNavigation { get; set; } = null!;
}
