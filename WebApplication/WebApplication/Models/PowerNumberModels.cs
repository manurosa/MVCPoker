using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class PowerNumber
    {
        private static PowerNumber Plus = new PowerNumber() { IsPlus = true };
        private static PowerNumber Minus = new PowerNumber() { IsMinus = true };

        public bool IsPlus { get; set; }
        public bool IsMinus { get; set; }

        public int Value { get; set; }

        public static PowerNumber GetValue(int value)
        {
            if (value == 100)
                return PowerNumber.Plus;

            if (value == 0)
                return PowerNumber.Minus;

            return new PowerNumber() { Value = value };
        }
    }
}