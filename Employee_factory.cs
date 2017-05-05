using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_project
{
    class Employee_factory
    {
        public Form Create_form(int id)
        {
            if ((id / 1000) == 11 || (id / 1000) == 10)
                return new Doctor(id);
            else if ((id / 1000) == 12)
                return new Reciptionist(id);
            else
                return new Storage(id);
        }
    }
}
