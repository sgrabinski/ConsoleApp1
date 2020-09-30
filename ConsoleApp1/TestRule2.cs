using System;

namespace ConsoleApp1
{
    class TestRule2
    {
        //test rule PB.DNUP
        //
        public double Foo1(string s)
        {
            // 2020-09-30 12:05
            // 2020-09-30 12:19 add in VS and send to git
            // 2020-09-30 12:28 add comment in VS and send to github
            // 2020-09-30 12:42 add comment in VS and send to github
            double doubleVal = Double.Parse(s);    // Violation
            return doubleVal;             
        }
        public double Foo2(string s)
        {
            //
            double doubleVal2 = Double.Parse(s);    // Violation
            return doubleVal2;
            // 2020-09-30 12:05
            // 2020-09-30 12:19 add in VS and send to git
            // 2020-09-30 12:42 add comment in VS and send to github
        }
        public double Foo3(string s)
        {
            //
            //
            // 2020-09-30 12:05
            // 2020-09-30 12:19 add in VS and send to git
            // 2020-09-30 12:28 add comment in VS and send to github
            // 2020-09-30 12:42 add comment in VS and send to github
            double doubleVal3 = Double.Parse(s);    // Violation
            return doubleVal3;
        }
    }
}
