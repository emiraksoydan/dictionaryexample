using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryexample
{
    public class Dictionaryy<L,R>
    {
        L[] Leftvalue;
        R[] Rightvalue;
        public Dictionaryy()
        {
            Leftvalue = new L[0];
            Rightvalue = new R[0];
        }

        public void Add(L solitem, R sagitem)
        {
            L[] temparraysol = Leftvalue;
            R[] temparraysag = Rightvalue;

            Leftvalue = new L[Leftvalue.Length + 1];
            Rightvalue = new R[Rightvalue.Length + 1];
            for (int i = 0; i < temparraysol.Length; i++)
            {
                Leftvalue[i] = temparraysol[i];
                Rightvalue[i] = temparraysag[i];
            }
            Leftvalue[Leftvalue.Length - 1] = solitem;
            Rightvalue[Rightvalue.Length - 1] = sagitem;
            
        }

       
        public L [] soldeger
        {
            get { return Leftvalue; }
        }
        public R [] sagdeger
        {
            get { return Rightvalue; }
        }
    }
}
