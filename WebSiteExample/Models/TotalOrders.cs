using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteExample.Models
{
    public partial class TotalOrders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public int TotalOrdersID { get; set; }
        public int? OrderID { get; set; }
        public int? ProductID { get; set; }
        public int Total { get; set; }
        public int AmountTotal { get; set; }

        public virtual Order Order { get; set; }
        public virtual Products Products { get; set; }
    }
}