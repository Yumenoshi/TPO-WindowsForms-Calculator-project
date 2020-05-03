using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Project.Models
{
    public class Calculation
    {
        private string _firstNumber;
        private string _operation;
        private string _secondNumber;
        private string _result;
        private string _type;

        public string FirstNumber { get => _firstNumber; set => _firstNumber = value; }
        public string Operation { get => _operation; set => _operation = value; }
        public string SecondNumber { get => _secondNumber; set => _secondNumber = value; }
        public string Result { get => _result; set => _result = value; }
        public string Type { get => _type; set => _type = value; }



        public Calculation(string firstNumber, string operation, string secondNumber, string result, string type)
        {
            FirstNumber = firstNumber;
            Operation = operation;
            SecondNumber = secondNumber;
            Result = result;
            Type = type;
        }

        public Calculation(string firstNumber, string operation, string secondNumber, string type)
        {
            FirstNumber = firstNumber;
            Operation = operation;
            SecondNumber = secondNumber;
            Result = null;
            Type = type;
        }
    }
}
