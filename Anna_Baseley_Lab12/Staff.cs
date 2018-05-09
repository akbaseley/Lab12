using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab12
{
    class Staff : Person
    {
        #region DataMembers
        private string school;
        private double pay;
        #endregion

        #region
        public string School { get => school; set => school = value; }
        public double Pay { get => pay; set => pay = value; }
        #endregion

        #region Constructors
        public Staff()
        {
            Pay = 35.00;
        }
        public Staff(string n, string a, string s, double p): base(n, a)
        {
            School = s;
            Pay = p;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Staff: {Name} \naddress: {Addess} \nschool: {School} \npay: {Pay}\n";
        }

        #endregion
    }
}
