using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSiteExample.Models
{
    [Table("Uye")]
    public partial class Uye
    {
        public Uye()
        {
            this.Basket = new HashSet<Basket>();
            this.Order = new HashSet<Order>();
        }
        public int UyeId { get; set; }

        [Required(ErrorMessage = "kullanıcı Adınızı giriniz.")]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifrenizi giriniz.")]
        [StringLength(20)]
        public string Sifre { get; set; }

        [Required]
        [StringLength(50)]
        public string AdSoyad { get; set; }

        public int? YetkiId { get; set; }
        

        public virtual Yetki Yetki { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Basket> Basket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }

    }
}