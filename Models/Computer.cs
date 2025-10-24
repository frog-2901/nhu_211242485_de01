using System;
using System.Collections.Generic;

namespace Nhu_211242485_de01.Models;

public partial class Computer
{
    public string NhuComId { get; set; } = null!;

    public string? NhuComName { get; set; }

    public string? NhuComPrice { get; set; }

    public string? NhuComImage { get; set; }

    public bool? NhuComStatus { get; set; }
}
