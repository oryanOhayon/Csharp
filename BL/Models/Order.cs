using System;
using System.Collections.Generic;

namespace BL.Models { 

public partial class Order
{
    public int? Orderid { get; set; }

    public int? PersonId { get; set; }

    public DateTime? EventDate { get; set; }

    public int? SumDresses { get; set; }

    public DateTime? ArrivalHour { get; set; }

    public virtual Person? Person { get; set; }
}
}
