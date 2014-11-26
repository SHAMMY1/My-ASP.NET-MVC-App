using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyPTC.Web.Models
{
	public class Person
	{

		public string Name { get; set; }

		public string Job { get; set; }

		public DateTime RegisteredOn { get; set; }

		public int Age { get; set; }
	}
}