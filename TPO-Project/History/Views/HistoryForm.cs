using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPO_Project.Models;

namespace TPO_Project.History.Views
{

    public partial class HistoryForm : Form, HistoryContract.IHistoryView
    {
        private HistoryContract.IHistoryPresenter presenter=new Presenters.HistoryPresenter();
        private DataBase.IDataBase dataBase = new DataBase.DataBase();

        private BindingSource bindingSource1 = new BindingSource();
        public HistoryForm()
        {
            InitializeComponent();
            nonGeneratedInitializeComponent();
            presenter.attachView(this);
            presenter.fetchData(dataBase);
        }

        public void Render(List<Calculation> calculations)
        {
            dataGridView1.Rows.Clear();
            foreach(Calculation calculation in calculations)
            {
                bindingSource1.Add(calculation);
            }
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Refresh();

        }



        private void ClearButton_Click(object sender, EventArgs e)
        {
            presenter.clearHistory(dataBase);
            presenter.fetchData(dataBase);
        }
    }
}
