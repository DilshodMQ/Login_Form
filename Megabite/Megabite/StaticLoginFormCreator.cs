using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megabite
{
    public class StaticLoginFormCreator
    {
        static LoginForm loginForm;
        public static LoginForm GetLoginForm()
        { return loginForm; }
    }
}
