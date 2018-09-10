using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Authenticate.DAL
{
    public class Login
    {
        [Key]
        public string UserEmail { set; get; }
        [Required]
        public string UserPassword { set; get; }
        [Required]
        public string UserName { set; get; }
        
    }
}
