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

namespace TPO_Project.Calculator.Views
{
    public partial class CalculatorForm : Form, CalculatorContract.ICalculatorView
    {
        private CalculatorContract.ICalculatorPresenter presenter=new Presenters.CalculatorPresenter();
        private DataBase.IDataBase dataBase = new DataBase.DataBase();
        public CalculatorForm()
        {
            InitializeComponent();
            this.AcceptButton = buttonEquals;
            presenter.attachView(this);
        }

        public void Render(Calculation calculation)
        {
            textBox1.Text = "" + calculation.FirstNumber + calculation.Operation + calculation.SecondNumber + "=" + calculation.Result;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length>0)
                this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1);
            this.textBox1.Select();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox1.Select();
        }
        private void button_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text+((Button)sender).Text;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            string text = this.textBox1.Text;
            string selectedItem = comboBoxType.SelectedItem.ToString();
            try
            {
                presenter.fetchResult(text, selectedItem, dataBase);
            }
            catch(DivideByZeroException)
            {
                ErrorLabel.Text = "Dzielenie przez zero!";
            }
            catch (ArgumentException)
            {
                ErrorLabel.Text = "Nieprawidłowy format!";
            }
           
            
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            History.Views.HistoryForm historyForm = new History.Views.HistoryForm();

            historyForm.Show();
        }
    }
}
