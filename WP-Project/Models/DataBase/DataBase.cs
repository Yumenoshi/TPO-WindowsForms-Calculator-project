using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP_Project.Models;

namespace WP_Project.DataBase
{
    public class DataBase : IDataBase
    {
        private string path = "history.txt";
        public void clearHistory()
        {
            if (File.Exists(path))
            {
                System.IO.File.WriteAllText(path, string.Empty);
            }
        }

        //File database convention:
        //firstNumber;Operation;SecondNumber;Result;Type
        public List<Calculation> fetchData()
        {
            List<Calculation> calculations = new List<Calculation>();
            if (File.Exists(path))
            {
                const Int32 BufferSize = 128;
                using (var fileStream = File.OpenRead(path))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                {
                    String line;
                    //Iteration
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        
                        String[] words=line.Split(';');
                        Calculation calculation = new Calculation(words[0],words[1],words[2],words[3],words[4]);
                        calculations.Add(calculation);
                    }

                }
            }
            return calculations;

        }

        public void insert(Calculation calculation)
        {
                string newLine =calculation.FirstNumber + ";" + calculation.Operation + ";" + calculation.SecondNumber + ";" + calculation.Result + ";" + calculation.Type;
                File.AppendAllText(path, newLine+Environment.NewLine);
        }
    }
}
