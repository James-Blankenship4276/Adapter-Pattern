 using System;
using System.Collections.Generic;
using System.Text;

namespace Bears
{
    class BearAdapter : ToyBear
    {
        Bear bears = new Grizzly();

        public void hug() {

            bears.maul();
        }
        
        public BearAdapter(Bear bear) {

            bears = bear;
           
            
        }

    }
}
