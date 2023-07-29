using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MCQ
{
    class Question
    {
        public string ques = "";
        public string op1 = "";
        public string op2 = "";
        public string op3 = "";
        public string ans = "";
        public Question()
        {
        }
        public Question(string q, string ans1, string ans2, string ans3,string Ans)
        {
            ques = q;
            op1 = ans1;
            op2 = ans2;
            op3 = ans3;
            ans = Ans;
        }

        public override string ToString()
        {
            return ques + "|" + op1 + "|" + op2 + "|" + op3+ "|" +ans;
        }
    }
}
