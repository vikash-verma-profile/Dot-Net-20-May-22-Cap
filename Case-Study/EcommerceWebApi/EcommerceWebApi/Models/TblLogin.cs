using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceWebApi.Models
{
    public partial class TblLogin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? IsAdmin { get; set; }
    }
}
