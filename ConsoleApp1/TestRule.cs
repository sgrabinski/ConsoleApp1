using System;

namespace ConsoleApp1
{
    class TestRule
    {
        //test rule PB.DNUP
        public double Foo(string s)
        {
            //
            double doubleVal = Double.Parse(s);    // Violation
            return doubleVal;
        }
        public double Foo2(string s)
        {
            double doubleVal2 = Double.Parse(s);    // Violation
            return doubleVal2;
            //
        }
        public double Foo3(string s)
        {
            //
            double doubleVal3 = Double.Parse(s);    // Violation
            return doubleVal3;
        }
    }
}
