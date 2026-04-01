using System;
using System.Collections.Generic;
using System.Text;

namespace LR_2._Structural_pattern.ProxyTestDrive
{
    internal class TestDriveProxy: ITestDrive
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool DriverLicense { get; set; }
        public TestDriveProxy(string firstName, string lastName, int age, bool driverLicense)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DriverLicense = driverLicense;
        }
        public void TestDrive()
        {
            if (Age < 18 || !DriverLicense)
            {
                Console.WriteLine("TestDriveProxy: " + LastName + " " + FirstName + " is not allowed to test drive.");
            }
            else
            {
                RealTestDrive realTestDrive = new RealTestDrive(FirstName, LastName);
                realTestDrive.TestDrive();
            }
        }
    }
}
