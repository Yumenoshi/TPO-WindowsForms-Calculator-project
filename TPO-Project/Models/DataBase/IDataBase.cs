using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPO_Project.DataBase
{
    public interface IDataBase
    {
        List<Models.Calculation> fetchData();
        void insert(Models.Calculation calculation);
        void clearHistory();
    }
}
