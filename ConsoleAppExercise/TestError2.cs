using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class TestError2:UserError
    {
        public override string UEMessage()
        {
            return "This is ERROR 2";
        }
    }
}
