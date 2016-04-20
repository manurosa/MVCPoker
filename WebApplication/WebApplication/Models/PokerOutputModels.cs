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

        public bool[,] Table { get; set; }

        public PokerOutputModels(int cpr, int csi, int pn)
        {
            CPR = cpr;
            CSI = csi;
            PN = pn;

            Table = new bool[13, 13];
            PowerNumberTableModel powerNumberTable = new PowerNumberTableModel();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    PowerNumber thisValue = powerNumberTable.Table[i, j];
                    Table[i, j] = IsValid(thisValue);
                }
            }
        }

        private bool IsValid(PowerNumber value)
        {
            if (value.IsPlus)
                return true;

            //if (value.IsMinus)
            //    return false; // Is this necessary¿?

            if (value.Value > PN)
                return true;

            return false;
        }
    }
}