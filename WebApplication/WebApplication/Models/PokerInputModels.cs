using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class PokerInputModels
    {
        [Required, Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        [Display(Name = "Small Blind")]
        public int SmallBlind { get; set; }
        [Required, Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        [Display(Name = "Big Blind")]
        public int BigBlind { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int Ante { get; set; }
        [Required, Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int Players { get; set; }
        [Required, Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int Stack { get; set; }
        [Required, Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        [Display(Name = "Remaining Opponents")]
        public int RemainingOpp { get; set; }
    }
}