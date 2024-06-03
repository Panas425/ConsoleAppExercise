using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class TestError3 : UserError
    {
        public override string UEMessage()
        {
            return "This is ERROR 3";
        }
    }
}
