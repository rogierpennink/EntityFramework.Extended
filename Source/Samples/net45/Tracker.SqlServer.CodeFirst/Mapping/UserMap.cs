using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Tracker.SqlServer.CodeFirst.Entities;

namespace Tracker.SqlServer.CodeFirst.Mapping
{
    public partial class UserMap
    {
        public void InitializeMapping()
        {
	        Property(t => t.Address.Street)
		        //.HasColumnName("Address_Street")
		        .IsOptional();
	        Property(t => t.Address.HouseNumber)
		        //.HasColumnName("Address_HouseNumber")
		        .IsOptional();
        }
    }
}
