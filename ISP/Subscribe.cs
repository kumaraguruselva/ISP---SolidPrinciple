using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class Subscribe : ISubscribe
    {
        public void Unsubsribe()
        {
            throw new NotImplementedException();
        }

        void ISubscribe.Subscribe()
        {
            throw new NotImplementedException();
        }
    }
}
