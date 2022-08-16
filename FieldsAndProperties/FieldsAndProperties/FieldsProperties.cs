using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsAndProperties
{
    class FieldsProperties
    {
        // Fields they're variables inside our class, structur
        // Fields can be read only!

        private string _test;
        private string _test1;
        private string _test2; // Some programmers use _ for private variables but it's not required
        private readonly string _test_readonly;

        // Constructor

        //public FieldsProperties(string test)
        //{
        //    _test2 = test;
        //}

        // Properties are field extensions
        // We can use them outside of our class
        // Not for the storage of value
        // They have access to the field to which they are assigned
        // Properties use get, set or both
        public string Test1
        {
            get { return _test1; }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _test1 = value;
                }
            }
        }

        // write only
        public string Test2
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _test2 = value;
                }
            }
        }

        // read only
        public string TestReadOnly
        {
            get { return _test_readonly; }
        }

        // Automatic property
        public int MyProperty { get; set; }

        // test
        public string Testing
        {
            get { return _test.ToUpper(); }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _test = value;
                }
            }
        }
    }
}
