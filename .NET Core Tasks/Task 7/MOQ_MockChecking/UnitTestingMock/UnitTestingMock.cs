using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockChecking;

namespace UnitTestingMock
{
    public class UnitTestingMockClass
    {
        public bool sendMsgToUser(MockCheckingclass msg)
        {

            var result = msg.sendMsg();
            if(result)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}
