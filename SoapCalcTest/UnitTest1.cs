using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoapCalcTest.ServiceRefrenceCalc;

namespace SoapCalcTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			using (CalcServiceClient client = new CalcServiceClient())
			{
				Assert.AreEqual(5, client.Add(3, 2));
			}
		}
	}
}
