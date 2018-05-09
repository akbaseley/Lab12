using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab12
{
    class Student : Person
    {
        #region DataMembers
        private string program;
        private int year;
        private double fee;
        #endregion

        #region Properties
        public string Program { get => program; set => program = value; }
        public int Year { get => year; set => year = value; }
        public double Fee { get => fee; set => fee = value; }
        #endregion

        #region Constructors
        public Student()
        {
            Year = 2018;
            Fee = 100.10;
        }
        public Student(string n, string a, string p, int y, double f) : base(n, a)
        {
            Program = p;
            Year = y;
            Fee = f;
        }

        public override string ToString()
        {
            return $"Student: {Name} \naddress: {Addess} \nprogram: {Program} \nyear: {Year} \nfee: {fee}\n";
        }
        #endregion


    }
}
