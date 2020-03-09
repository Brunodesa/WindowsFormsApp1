using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador
{
    class Contentor
    {
        private string _path = Application.StartupPath + "\\Contador.txt";

        public void contar(object sender)
        {
            Button _b = (Button)sender;
            int valor = Convert.ToInt32(_b.Text) + 1;
            _b.Text = valor.ToString();
            File.WriteAllText(_path, valor.ToString());

        }

        public string Abrir()
        {
            if (File.Exists(_path)) return File.ReadAllText(_path);
            else return "0";
        }
    }
}

