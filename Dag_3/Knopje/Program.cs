using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knopje
{
    class Program
    {
        static void Main(string[] args)
        {
            Form f1 = new Form();
            f1.Text = "Hallo Form";

            Button b1 = new Button();
            b1.Location = new Point(100, 200);
            b1.Text = "Hehehe";

            b1.Click += Blah;
            b1.Click += Blah;
            b1.Click += Blah;
            f1.Controls.Add(b1);

            f1.ShowDialog();
        }

        private static void Blah(object sender, EventArgs e)
        {
            Console.WriteLine("Aha!!");
            //Button b1 = sender as Button;
            //b1.Parent.BackColor = Color.Red;
        }
    }
}
