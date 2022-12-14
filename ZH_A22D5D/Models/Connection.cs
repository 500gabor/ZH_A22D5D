using System;
using System.Collections.Generic;

namespace ZH_A22D5D.Models;

public partial class Connection
{
    public int ConnectionId { get; set; }

    public int PortfolioFk { get; set; }

    public int StocksFk { get; set; }

    public virtual Portfolio PortfolioFkNavigation { get; set; } = null!;

    public virtual Stocks StocksFkNavigation { get; set; } = null!;
}
