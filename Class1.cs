using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITBITSECB
{
    public class Class1
    {
        public void PublicFunc()
        {
            Console.WriteLine("Public Function");
            Console.WriteLine("Class updated");
        }
        protected void ProtectedFunc()
        {
            Console.WriteLine("Protected Function");
            Console.WriteLine("Class updated");
        }
    }
    public class Class2
    {
        public void PublicFunc() {}
        private void PrivateFunc() { }
        protected void ProtectedFunc() { }
        internal  void InternalFunc() { }
        protected internal void ProIntFunc() { }
        private protected void PriProFunc() { }

    }
}
