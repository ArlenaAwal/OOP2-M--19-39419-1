﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student("Arlena", "654376", "cse", 3.43f);
            obj1.showInfo();
            Triangle obj2 = new Triangle(10, 20, 10);
            obj2.ShowInfo();
            obj2.TestTriangle();
            Course obj3 = new Course("OOP2", "23425325", 3);
            obj3.ShowInfo1();
            Account obj4 = new Account("Arlena", "4567", 500);
            obj4.Deposit(500);
            obj4.Withdraw(500);
            
        }
    }
}
