using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace convertnumbertoword.convertnumericwords
{
    public class convertnumbertospellswords
    {

        private static String ConvertDecimals(String number)
        {
            String cd = "", digit = "", engOne = "";
            for (int i = 0; i < number.Length; i++)
            {
                digit = number[i].ToString();
                if (digit.Equals("0"))
                {
                    engOne = "Zero";
                }
                else
                {
                    engOne = ones(digit);
                }
                cd += " " + engOne;
            }
            return cd;
        }
    }
}