using System;
using System.Collections.Generic;

namespace ZH_A22D5D.Models;

public partial class Portfolio
{
    public int PortfolioSk { get; set; }

    public string PortfolioName { get; set; } = null!;

    public virtual ICollection<Connection> Connection { get; } = new List<Connection>();
}
