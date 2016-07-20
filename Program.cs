using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] o = new object[] { "C",2,"Z", 3, "A",1};
            

            List<string> ls = new List<string>();
            List<int> li = new List<int>();

            string[] sa = new string[o.Length];
            int[] si = new int[o.Length];

            int Scounter = 0;
            int Icounter = 0;
            for (int i = 0; i < o.Length; i++)
            {
                if (o[i] is string)
                {
                    Scounter++;
                    ls.Add(Convert.ToString(o[i]));
                    sa[i] = Convert.ToString(o[i]);



                }
                if (o[i] is int)
                {
                    Icounter++;
                    li.Add(Convert.ToInt32(o[i]));
                    si[i] = Convert.ToInt32(o[i]);

                }

            }

            string[] sa2 = new string[Scounter];
            int[] si2 = new int[Icounter];

            for (int i = 0; i < sa.Length; i++)
            {
                if (sa[i] != null)
                {
                    sa2[Scounter-1] = sa[i];
                    Scounter--;
                }

            }
            for (int i = 0; i < sa.Length; i++)
            {
                if (si[i] != 0)
                {
                    si2[Icounter - 1] = si[i];
                    Icounter--;
                }

            }



            //for (int ii = 0; ii < sa.Length ; ii++)
            //{
            //    if (o[ii] is string)
            //    {

            //        sa[ii] = Convert.ToString(o[ii]);

            //    }
            //    //if (o[ii] is int)
            //    //{

            //    //      ia[ii] = Convert.ToInt32(o[ii]);
            //    //}

            //}
        }

    }
}
