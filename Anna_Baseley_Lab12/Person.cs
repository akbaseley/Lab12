using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab12
{
    class Person
    {
        #region DataMembers
        private string name;
        private string addess;
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public string Addess { get => addess; set => addess = value; }
        #endregion

        #region Constructors
        public Person()
        {
            Addess = "800 S Military St.";
        }
        public Person(string n, string a)
        {
            Name = n;
            Addess = a;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Person: {Name} \naddress: {Addess} \n";
        }

        #endregion
    }
}
