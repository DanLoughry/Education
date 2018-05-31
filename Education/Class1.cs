using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
	class Class1
	{
		public string Name { get; set; }
		public string Language { get; set; }  //C# or Java
		public string Code { get; set; }  //code to be determined later (ie 2018-02/)
		public int Capacity { get; set; }
		public Instructor Instructor { get; set; }
		public List<Student> Students = new List<Student>();
	}
}	