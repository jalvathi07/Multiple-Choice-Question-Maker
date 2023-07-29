using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MCQ
{
    class Validation
    {
       public int mark = 0;
       public int Validate(string []ar1,string[]ar2)
       {
           for (int i = 0; i < 5; i++)
           {
               if (ar1[i] != ar2[i])
               {
                   mark += 0;
               }
               else if (ar1[i] == ar2[i])
               {
                   mark += 2;
               }
           }
           return mark; ;
       }
       public void CheckArray(string []ar)
       {
           for (int i = 0; i < 5; i++)
           {
               if (ar[i] == null)
               {
                   ar[i] = "NOT ANSWERED";
               }
               else
               {
                   ar[i] = ar[i];
               }
           }
       }
    }
}
