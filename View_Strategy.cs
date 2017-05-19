using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Hospital_project
{
   public class View_Strategy
    {
       public View_Strategy()
       {

       }
        public virtual DataTable View_operation(int id)
        {
            return null;
        }
    }
}
