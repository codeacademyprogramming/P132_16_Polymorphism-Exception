using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class WarrantyStudent:Student
    {
        public string PrevGroupNo;

        public override void ShowInfo()
        {
            Console.WriteLine($"Fullname: {Name} {Surname} - GroupNo: {GroupNo} - PrevGroupNo: {PrevGroupNo}");
        }
    }
}
