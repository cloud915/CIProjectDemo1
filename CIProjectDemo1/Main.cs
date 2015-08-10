using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIProjectDemo1
{
    public class Main
    {
        public int PrintNumberSquare(int num)
        {
            return num*num;
        }

        public string PrintString(string str)
        {
            return string.Format("现在输出的内容是：{0}", str);
        }
        public string PrintString2(string str)
        {
            return string.Format("修改项目内容，现在输出的内容是：{0}", str);
        }

        public string PrintException(string str)
        {
            throw new Exception("异常举例");
        }
    }
}
