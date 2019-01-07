using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPO_Project.Calculator.Presenters
{
    class GenericCalculator<T>
    {
        public T calculate(T first, String operation, T second)
        {
            dynamic a=first;
            dynamic b=second;
            switch (operation)
            {

                case "+":
                    return (T)(a+b);
                case "-":
                    return (T)(a - b);
                case "*":
                    return (T)(a * b);
                case "/":
                    return (T)(a / b);
            }

            throw new ArgumentException();
        }
    }
}
