using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tracker.SqlServer.CodeFirst.Entities
{
    public partial class User
    {
		public Address Address { get; set; }
    }

	[ComplexType]
	public class Address
	{
		public string Street { get; set; }

		public string HouseNumber { get; set; }
	}
}