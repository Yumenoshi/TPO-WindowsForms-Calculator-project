using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP_Project.DataBase;

namespace WP_Project.History.Presenters
{
    class HistoryPresenter : HistoryContract.IHistoryPresenter
    {
        private HistoryContract.IHistoryView View;
        public void attachView(HistoryContract.IHistoryView View)
        {
            this.View = View;
        }

        public void clearHistory(IDataBase dataBase)
        {
            dataBase.clearHistory();
        }

        public void detachView()
        {
            this.View = null;
        }

        public void fetchData(IDataBase dataBase)
        {
            List<Models.Calculation> calculations = dataBase.fetchData();
            View.Render(calculations);
        }
    }
}
