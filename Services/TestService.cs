using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabuTalk.Services
{
    public class TestService : ITestService
    {
        public string GetString()
        {
            return "테스트 입니다";
        }
    }
}
