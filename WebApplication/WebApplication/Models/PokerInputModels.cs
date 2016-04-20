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
        public int? Ante { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int Players { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int Stack { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        [Display(Name = "Remaining Opponents")]
        public int RemainingOpp { get; set; }


        public PokerOutputModels Calculate()
        {
            int cpr;

            if (Ante.HasValue)
                cpr = BigBlind + SmallBlind;
            else
                cpr = BigBlind + SmallBlind + Ante.Value * Players;

            int csi = Stack / RemainingOpp;

            int pn = csi * RemainingOpp;

            return new PokerOutputModels(cpr, csi, pn);
        }
    }
}