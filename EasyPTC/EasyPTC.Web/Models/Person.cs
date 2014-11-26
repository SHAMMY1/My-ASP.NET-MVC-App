using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyPTC.Web.Models
{
	public class Person
	{
		[MinLength(5,ErrorMessage="TOO SHORT")]
		public string Name { get; set; }
		[Required]
		public int Age { get; set; }
	}
}