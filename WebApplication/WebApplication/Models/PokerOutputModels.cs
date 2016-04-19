using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class PokerOutputModels
    {
        [Required]
        public int CPR { get; private set; }
        [Required]
        public int CSI { get; private set; }
        [Required]
        public int PN { get; private set; }

    }
}