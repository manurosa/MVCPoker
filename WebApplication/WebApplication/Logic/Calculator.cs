using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Logic
{
    public class Calculator
    {
        public PokerOutputModels Calculate(PokerInputModels input)
        {
            int cpr;

            if (input.Ante.HasValue)
                cpr = input.BigBlind + input.SmallBlind;
            else
                cpr = input.BigBlind + input.SmallBlind + input.Ante.Value * input.Players;

            int csi = input.Stack / input.RemainingOpp;

            int pn = csi * input.RemainingOpp;

            return new PokerOutputModels(cpr, csi, pn);
        }
    }
}