using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern 
{
    
    public abstract class Binaire : Expression
    {
        protected Expression n1;
        protected Expression n2;
        protected Binaire(Expression op1,Expression op2)
        {
            n1 = op1;
            n2 = op2;
        }

    }
}
