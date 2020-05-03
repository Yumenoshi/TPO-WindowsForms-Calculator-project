using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WP_Project.Models
{
    class RegexHandler : Calculator.CalculatorContract.IRegexInterface
    {
        private const string regex = @"(^[-]?\d+([.]?\d+)?[-\+\/*][-]?\d+([.]?\d+)?$)";
        private Regex regexPattern = new Regex(regex);
        private Regex signRegex = new Regex(@"[-\+\/*]");
        public bool IsMatch(string text)
        {
            return regexPattern.IsMatch(text);
        }

        public Calculation split(string text,string type)
        {
            //values: 0 - first number, 1 - operation, 2 - second number

            string[] values=new string[3];
            string temp = "";
            bool flag = true;
            for(int i = 0; i < text.Length; i++)
            {
                temp += text[i];
                //we skip first sign, as it can be both number and '-' sign
                if (i > 0)
                {
                    //flag will guard against second number starting with '-'
                    if (signRegex.IsMatch(""+text[i])&&flag==true)
                    {
                        //removing sign of operation from first number
                        values[0] = temp.Remove(temp.Length-1);
                        flag = false;
                        temp = "";
                        values[1] = "" + text[i];
                    }
                }
            }
            values[2] = temp;

            Calculation result = new Calculation(values[0], values[1], values[2], type);
            return result;
        }
    }
}
