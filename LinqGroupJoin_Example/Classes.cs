using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoin_Example
{
    public class Classes
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public Classes(int classId, string className)
        {
            ClassId = classId;
            ClassName = className;
        }
    }
}
