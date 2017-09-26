using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapCalc
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalcService" in both code and config file together.
	[ServiceContract]
	public interface ICalcService
	{
		[OperationContract]
		double Add(double a, double b);
	}
}
