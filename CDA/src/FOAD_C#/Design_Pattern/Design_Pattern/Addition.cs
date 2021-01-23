using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class Addition : Binaire
    {
       

        public Addition(Expression op1, Expression op2) : base(op1,op2)
        {
        }

        public override int Evalue()
        {
            return n1.Evalue() + n2.Evalue() ; 
        }
        public override string ToString()
        {
            return n1.ToString() + "+" + n2.ToString();
        }
        public override string Formate()
        {
            return this.ToString() + "=" + this.Evalue().ToString();
        }
    }
}
