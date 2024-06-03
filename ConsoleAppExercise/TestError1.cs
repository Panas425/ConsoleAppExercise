using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class TestError1 : UserError
    {
        public override string UEMessage()
        {
            return "This is ERROR 1";
        }
    }
}
