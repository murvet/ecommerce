using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteExample.Models
{
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.TotalOrders = new HashSet<TotalOrders>();
        }

        public int OrderID { get; set; }
        public int? UyeID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string TCKimlikNo { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }

        public virtual Uye Uye { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TotalOrders> TotalOrders { get; set; }
    }
}