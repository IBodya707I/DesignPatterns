using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.ProxyTestDrive
{
    internal class RealTestDrive: ITestDrive
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public RealTestDrive(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }   
        public void TestDrive()
        {
            Console.WriteLine("RealTestDrive: " + LastName + " " + FirstName);
        }
    }
}
