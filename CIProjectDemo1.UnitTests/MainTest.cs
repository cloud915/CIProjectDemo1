using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CIProjectDemo1.UnitTests
{
   public class MainTest
    {
       public Main main=null;

       [SetUp]
       public void Setup()
       {
           main=new Main();
       }

       [Test]
       public void NumberTest()
       {
           var result = main.PrintNumberSquare(10);

           Assert.IsInstanceOf<int>(result);
           Assert.AreEqual(100,result);
       }
       [Test]
       public void StringTest()
       {
           var result = main.PrintString("单元测试中");

           Assert.IsInstanceOf<string>(result);
           Assert.AreEqual("现在输出的内容是：单元测试中", result);
       }

       [Test]
       public void StringTest2()
       {
           var result = main.PrintString2("单元测试中");

           Assert.IsInstanceOf<string>(result);
           Assert.AreEqual("修改项目内容，现在输出的内容是：单元测试中", result);
       }

    }
}
