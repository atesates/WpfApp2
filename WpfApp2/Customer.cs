using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Customer
    {
        private string _CustomerCode = "";
        public string CustomerCode { get { return _CustomerCode.ToUpper(); } set { _CustomerCode = value; } }
    }
}
