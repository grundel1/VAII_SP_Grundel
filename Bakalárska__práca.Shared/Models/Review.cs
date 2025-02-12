﻿using Bakalárska__práca.Shared.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakalárska__práca.Shared.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int DentistId { get; set; }
        [ForeignKey("DentistId")]
        public Dentist Dentist { get; set; } = null!;
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; } = null!;
        public int Rating { get; set; }
        [StringLength(50)]
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}
