using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPO_Project.Models;

namespace TPO_Project.Calculator
{
    public class CalculatorContract
    {
        public interface ICalculatorView
        {
            void Render(Models.Calculation calculation);
        }

        public interface ICalculatorPresenter
        {
            void attachView(CalculatorContract.ICalculatorView View);
            void detachView();
            void fetchResult(string text, string type,DataBase.IDataBase dataBase);
        }
        public interface IRegexInterface
        {
            bool IsMatch(string text);
            Calculation split(string text, string type);
        }
    }
}
