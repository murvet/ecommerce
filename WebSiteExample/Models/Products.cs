using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSiteExample.Models
{
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.Basket = new HashSet<Basket>();
            this.TotalOrders = new HashSet<TotalOrders>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Product title is required")]
        [MaxLength(45, ErrorMessage = "The maximum length must be upto 45 characters only")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Product description is required")]
        [MaxLength(255, ErrorMessage = "The maximum length must be upto 255 characters only")]
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public int ProductPrice { get; set; }

        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Basket> Basket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TotalOrders> TotalOrders { get; set; }
    }
}