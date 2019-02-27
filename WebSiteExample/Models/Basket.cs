using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteExample.Models
{
    public partial class Basket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public int BasketID { get; set; }
        public int? UserID { get; set; }
        public int? ProductID { get; set; }
        public int Total { get; set; }
        public int AmountTotal { get; set; }
       
        public virtual Uye Uye { get; set; }
        public virtual Products Products { get; set; }
    }
}