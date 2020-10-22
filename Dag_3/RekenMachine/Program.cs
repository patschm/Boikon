using System;

namespace RekenMachine
{
    delegate int MathDel(int ax, int y);

    class Program
    {
        static void Main(string[] args)
        {
            SimonVdMeer svdm = new SimonVdMeer();
            WillemKlein wk = new WillemKlein();

            //wk.Reken(svdm.Add, 3,4);
            //wk.Reken(svdm.Subtract, 8, 7);


            // Multicast delegate
            MathDel m1 = svdm.Add;
            m1 += svdm.Subtract; 
            m1 += Multiply;
            m1 += svdm.Subtract;
           

            foreach(var met in m1.GetInvocationList())
            {
                Console.WriteLine(met.Method.Name);
            }

            int res = m1(1, 2);
            Console.WriteLine(res);

        }

        static int Multiply(int u, int v)
        {
            return u * v;
        }
    }
}
