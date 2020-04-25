using MyDevopsDemo;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDevopsDemoTEST
{
    class MathsOperationTest
    {
        [Test()]
        public void AddTest()
        {
            MathsOperation mo = new MathsOperation();
            mo.Add(10, 20);
            Assert.AreEqual(true,30);
        }
        public void SubtractTest()
        {
            MathsOperation mo = new MathsOperation();
            mo.Subtract(20, 10);
            Assert.AreEqual(true, 10);
        }
        public void Multiply()
        {
            MathsOperation mo = new MathsOperation();
            mo.Add(10, 20);
            Assert.AreEqual(true, 200);
        }
        public void DivideTest()
        {
            MathsOperation mo = new MathsOperation();
            mo.Add(20, 10);
            Assert.AreEqual(true, 2);
        }

    }
}
