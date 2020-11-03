using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekenMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            int a = (int)nrA.Value;
            int b = (int)nrB.Value;

            int result = await AddAsync(a, b);
            UpdateAnswer(result);

            //int result = Add(a, b);
            //UpdateAnswer(result);

            //var handvatNaarOwner = SynchronizationContext.Current;
            //Func<int, int, int> m1 = Add;
            //m1.BeginInvoke(1, 2, ar =>
            //{
            //    int result = m1.EndInvoke(ar);
            //    handvatNaarOwner.Post(UpdateAnswer, result);            
            //}, null);

            //Task.Run(() => Add(a, b))
            //    .ContinueWith(pt => handvatNaarOwner.Post(UpdateAnswer, pt.Result));

            //Task.Run(() => {
            //    int result = Add(a, b);
            //    handvatNaarOwner.Post(UpdateAnswer, result);
            //});


        }

        private void UpdateAnswer(object obj)
        {
            lblAnswer.Text = obj.ToString();
        }

        private int Add(int a, int b)
        {
            Task.Delay(10000).Wait();
            return a + b;
        }
        private Task<int> AddAsync(int a, int b)
        {
            return Task.Run(() => Add(a, b));
        }
    }
}
