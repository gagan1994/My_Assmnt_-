using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assisment_3_WebForms
{

	public partial class Default
	{
		protected Button submit;
		protected Button details;
		protected TextBox name, age, email, address;
		protected TableRow r;
		protected TableCell c;
		protected Table Table1;
		protected Button[] delete;
		protected Button[] edit;

	}
	public class CustomerDetails
	{
		public int Id{ get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
	}
}
