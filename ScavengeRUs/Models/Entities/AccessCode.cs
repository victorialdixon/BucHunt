﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScavengeRUs.Models.Entities
{
    public class AccessCode
    {
        public int Id { get; set; }
        [DisplayName("Access Code")]
        public string? Code { get; set; }
        public int HuntId { get; set; }
        [NotMapped]
        public Hunt? Hunt{ get; set; }
        public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
