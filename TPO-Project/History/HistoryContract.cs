using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPO_Project.History
{
    class HistoryContract
    {
        public interface IHistoryView
        {
            void Render(List<Models.Calculation> calculations);
        }

        public interface IHistoryPresenter
        {
            void fetchData(DataBase.IDataBase dataBase);
            void attachView(HistoryContract.IHistoryView View);
            void detachView();
            void clearHistory(DataBase.IDataBase dataBase);
        }
    }
}
 