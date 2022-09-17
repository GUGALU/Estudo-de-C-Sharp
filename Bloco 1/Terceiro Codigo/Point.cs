using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Terceiro_Codigo{
    struct Point{

       public double x;
       public double y;

        public override string ToString(){
            return "(" + x + "," + y  + ")";
        }
    }
}