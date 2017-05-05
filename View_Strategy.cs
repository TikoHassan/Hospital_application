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
        Doctor_controller c;
        public View_Strategy()
        {
            c = new Doctor_controller();
        }
        public virtual DataTable View_operation(int id)
        {
            return null;
        }
    }
}
