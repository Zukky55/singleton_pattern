using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class RegisterNote
    {
        private static RegisterNote registerNote = new RegisterNote();
        private RegisterNote() { }

        public static RegisterNote GetInstance()
        {
            return registerNote;
        }
    }
}
