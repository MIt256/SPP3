using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLib
{
    class Example2
    {
        private int foo;
        public string str;
        protected bool flag;

        public Example2(int foo, string str, bool flag)
        {
            this.foo = foo;
            this.str = str;
            this.flag = flag;
        }

        public int Foo
        {
            get => foo;
            set => foo = value;
        }

        private int GetStrLength()
        {
            return str.Length;
        }
    }
}
