using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestProject1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        
            public void TestMethod1()
            {
                //AAA
                //Arrange
                Program program = new Program();

                //Act
                int result = program.Add(5, 10);

                //Assert
                Assert.AreEqual(15, result);
            }

        }
    }

    internal class Program
    {
        internal int Add(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }

