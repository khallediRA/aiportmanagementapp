﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
        public string Function { get; set; }
        public DateTime EmploymentDate { get; set; }
        public float Salary { get; set; }

        public override void PassengerType()
        {
            Console.WriteLine("I am a staff");

        }

    }
}
