using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest
{
    class ARandomClass
    {
        Random r;
        public ARandomClass(int a)
        {
            r = new Random(a + DateTime.Now.Millisecond);
        }

        public int GetRandomNumber()
        {
            return r.Next();
        }
    }
}
