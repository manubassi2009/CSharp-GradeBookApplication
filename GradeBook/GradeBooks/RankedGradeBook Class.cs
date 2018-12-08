using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook_Class : BaseGradeBook
    {
        public RankedGradeBook_Class(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
