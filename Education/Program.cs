using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
	class Program
	{
		static void Main(string[] args)	{

			Instructor danTheMan = new Instructor();
			danTheMan.Name = "Dan";
			danTheMan.ExperienceInYears = 17;
			danTheMan.PrimaryLanguage = "CSharp";
			danTheMan.Email = "danTheMan@military.gov";
			danTheMan.Phone = "123-456-7890";

			Class1 dotnetbc = new Class1();
			dotnetbc.Capacity = 16;
			dotnetbc.Code = "DN4";
			dotnetbc.Language = "CSharp";
			dotnetbc.Name = "Dot Net Boot Camp";
			dotnetbc.Instructor = danTheMan;

			Student Foster = new Student();
			Foster.Absences = 0;
			Foster.ContactInfo = "Call FOster...";
			Foster.FirstJob = DateTime.MinValue;
			Foster.Name = "Foster";
			Foster.Class = dotnetbc;

			Student JJ = new Student();
			JJ.Absences = 5;
			JJ.ContactInfo = "Be worth more letters...";
			JJ.FirstJob = DateTime.MinValue;
			JJ.Name = "JJ";
			JJ.Class = dotnetbc;

			dotnetbc.Students.Add(Foster);
			dotnetbc.Students.Add(JJ);
			
		}
	}
}
