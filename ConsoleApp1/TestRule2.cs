using System;

namespace ConsoleApp1
{
    class TestRule2
    {
        //test rule PB.DNUP
        public double Foo1(string s)
        {
            // 2020-09-30 11:04
            double doubleVal = Double.Parse(s);    // Violation
            return doubleVal;
            //
        }
        public double Foo2(string s)
        {
            double doubleVal2 = Double.Parse(s);    // Violation
            return doubleVal2;
            //
            // 2020-09-30 11:04
        }
        public double Foo3(string s)
        {
            //
            // 2020-09-30 11:04
            double doubleVal3 = Double.Parse(s);    // Violation
            return doubleVal3;
        }
    }
}
