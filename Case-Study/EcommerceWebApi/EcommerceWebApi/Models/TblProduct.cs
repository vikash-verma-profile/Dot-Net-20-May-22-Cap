using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceWebApi.Models
{
    public partial class TblProduct
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int? CatId { get; set; }
        public string ProductImage { get; set; }
        public decimal? ProductMrp { get; set; }
        public decimal? ProductDiscount { get; set; }
        public decimal? ProductFinal { get; set; }
        public int? ProductQuantity { get; set; }
    }
}
