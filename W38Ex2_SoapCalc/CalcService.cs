﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace W38Ex2_SoapCalc
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalcService" in both code and config file together.
	public class CalcService : ICalcService
	{
		public double Add(double a, double b)
		{
			return a + b;
		}
	}
}
