using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Management_System.Models
{
    public class Solution
    {
        public string sol;
        public int grade;
        public Student student;

        public Solution(string sol, Student s)
        {
            this.sol = sol;
            this.student = s;
        }
    }
}
