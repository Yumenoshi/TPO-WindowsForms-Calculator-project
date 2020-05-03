using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP_Project.Models;

namespace WP_Project.Calculator.Presenters
{
    class CalculatorPresenter : Calculator.CalculatorContract.ICalculatorPresenter
    {
        private CalculatorContract.ICalculatorView View;
        private CalculatorContract.IRegexInterface regex=new RegexHandler();
        private NumberFormatInfo nfi = new NumberFormatInfo();
        public void attachView(CalculatorContract.ICalculatorView View)
        {
            this.View = View;
            nfi.NumberDecimalSeparator = ".";
        }
        public void detachView()
        {
            this.View = null;
        }
        public void fetchResult(string Text, string Type, DataBase.IDataBase dataBase)
        {
            //Check if Text from textbox maches regex of calculation
            if (regex.IsMatch(Text))
            {
                //split Text from textbox into calculation object
                Calculation calculation = regex.split(Text,Type);
                //Try to calculate
                //test calculation if not divide by zero
                if (double.Parse(calculation.SecondNumber, CultureInfo.InvariantCulture) == 0 && calculation.Operation.Equals("/"))
                    throw new DivideByZeroException();
                //Making generic calculator object based on type from calculation:
                
                //casting numbers to biggest scope
                double firstNumber= double.Parse(calculation.FirstNumber, CultureInfo.InvariantCulture);
                double secondNumber= double.Parse(calculation.SecondNumber, CultureInfo.InvariantCulture);

                string result="";
                //Cannot use switch becouse of Equals function
                if (calculation.Type.Equals("Integer"))
                {
                    GenericCalculator<int> genericCalculator = new GenericCalculator<int>();
                    string a;
                    string b;
                    try
                    { 
                        int index = calculation.FirstNumber.IndexOf(".");
                        if (index > 0)
                            a = calculation.FirstNumber.Substring(0, index);
                        index = calculation.SecondNumber.IndexOf(".");
                        if (index > 0)
                            b = calculation.SecondNumber.Substring(0, index);
                    }
                    catch
                    {

                    }
                    
                    result = "" + genericCalculator.calculate((int)firstNumber, calculation.Operation, (int)secondNumber);
                }
                else if (calculation.Type.Equals("Double"))
                {
                    GenericCalculator<double> genericCalculator = new GenericCalculator<double>();
                    result = "" + genericCalculator.calculate(firstNumber, calculation.Operation, secondNumber);
                }
                else if (calculation.Type.Equals("Unsigned Integer"))
                {
                    if (firstNumber < 0) firstNumber = 0;
                    if (secondNumber < 0) secondNumber = 0;
                    GenericCalculator<uint> genericCalculator = new GenericCalculator<uint>();
                    result =""+ genericCalculator.calculate((uint)firstNumber, calculation.Operation, (uint)secondNumber);
                }
                calculation.Result = result.Replace(',', '.');
                dataBase.insert(calculation);
                View.Render(calculation);
            }
            else
            {
                throw new ArgumentException();
            }
           
        }
    }
}
