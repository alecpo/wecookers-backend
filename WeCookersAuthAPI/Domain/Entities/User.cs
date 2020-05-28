using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WeCookersAuthAPI.Domain.Entities
{
    [DataContract]
    public class User
    {
        [Key]
        [Column]
        public Guid Id { get; set; }
        
        [Column]
        public string Name { get; set; }

        [Column]
        public string Email { get; set; }

        [Column]
        public string Password { get; set; }

        [Column]
        public bool AllowedFlag { get; set; }

    }
}
