using System;
using System.Collections.Generic;
using System.Text;

namespace Class4_assignment
{
    class Colleague : Person
    {

        public Colleague DeptNum;

        /// <summary>
        /// Default constructor attempt 1
        /// </summary>
        public Colleague()
        {
            string DeptNum = "A12";
        }

        /// <summary>
        /// Default constructor that uses inheritance
        /// </summary>
        //public Student() : base()
        //{
        //  studentNumber = "U1234";
        //}
    }
}
