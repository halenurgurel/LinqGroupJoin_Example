using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoin_Example
{
    public class Students
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }

        public Students(int studentId, string studentName, int classId)
        {
            StudentId = studentId;
            StudentName = studentName;
            ClassId = classId;
        }
    }
}
