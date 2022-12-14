using System;
using System.Collections.Generic;

namespace ZH_A22D5D.Models;

public partial class Stocks
{
    public int StockSk { get; set; }

    public string Ticker { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Market { get; set; } = null!;

    public double Price { get; set; }

    public virtual ICollection<Connection> Connection { get; } = new List<Connection>();
}
