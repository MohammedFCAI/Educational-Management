using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Management_System.Models
{
    public class Assignment
    {
        public int id;
        public ArrayList solutions = new ArrayList();

        public Assignment(int id)
        {
            this.id = id;
        }
    }
}
