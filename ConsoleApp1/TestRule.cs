using System;

namespace ConsoleApp1
{
    class TestRule
    {
        //test rule PB.DNUP
        public double Foo(string s)
        {
            double doubleVal = Double.Parse(s);    // Violation
            return doubleVal;
        }
    }
}
