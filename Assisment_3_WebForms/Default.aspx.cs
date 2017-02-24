using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assisment_3_WebForms
{

	public partial class Default : System.Web.UI.Page
	{
		bool flag = true;

		string err = "This field cant be empty";
		static List<CustomerDetails> cList;
	



		public Default()
		{
			if (cList == null)
			{
				cList = new List<CustomerDetails>();
				cList.Add(new CustomerDetails()
				{
					Id=0,
					Name = "Anonymus",
					Age = 10,
					Address = "No Adddress",
					Email = "example@gmail.com"
				});
			}
		}


		public void OnSubmit(object sender, EventArgs args)
		{

			if (name.Text.Trim().Length==0)
			{
				flag = false;
				name.Attributes.Add("placeholder", err);
			}
			if (age.Text.Trim().Length == 0)
			{
				flag = false;
				age.Attributes.Add("placeholder", err);
			}
			if (email.Text.Trim().Length == 0)
			{
				flag = false;
				email.Attributes.Add("placeholder", err);
			}
			if (address.Text.Trim().Length == 0)
			{
				flag = false;
				address.Attributes.Add("placeholder", err);
			}
			if (flag)
			{

				cList.Add(new CustomerDetails()
				{
					Id=cList.Count,
					Name = name.Text,
					Age = int.Parse(age.Text),
					Address = address.Text,
					Email = email.Text

				});
				name.Text = "";
				age.Text = "";
				email.Text = "";
				address.Text = "";

			
			}
			else
			{
				
			}

			submit.Text = "You clicked me";
		}
		public void OnDetails(object sender, EventArgs args)
		{
			details.Text = "You clicked me";
			int i = 0;
			delete = new Button[cList.Count];
			edit = new Button[cList.Count];
			Table1.CellSpacing = 10;
			foreach (var cin in cList)
			{
				r = new TableRow();
				TableCell n1 = new TableCell();
				TableCell n2 = new TableCell();
				TableCell n3 = new TableCell();
				TableCell n4 = new TableCell();
				TableCell n5 = new TableCell();



				if (cin.Id==0)
				{
					n1.Controls.Add(new LiteralControl("Name"));
					n2.Controls.Add(new LiteralControl("Age"));
					n3.Controls.Add(new LiteralControl("Email"));
					n4.Controls.Add(new LiteralControl("Address"));

					r.Cells.Add(n1);
					r.Cells.Add(n2);
					r.Cells.Add(n3);
					r.Cells.Add(n4);
					Table1.Rows.Add(r);
					continue;
				}
				r = new System.Web.UI.WebControls.TableRow();
			//del
				delete[i] = new Button();
				delete[i].ID = cin.Id.ToString();

				delete[i].UseSubmitBehavior = false;
				delete[i].Text="Delete";

				//delete[i].Click += new EventHandler(Delete);
				delete[i].Attributes["runat"] = "server";
				delete[i].Attributes["OnClick"]="DeleteKartItems("+cin.Id+",\"DeleteItem\");return false";

				//edit
				edit[i] = new Button();
				edit[i].ID = cin.Id.ToString();

				edit[i].UseSubmitBehavior = false;
				edit[i].Text = "Edit";

				//delete[i].Click += new EventHandler(Delete);
				edit[i].Attributes["runat"] = "server";
				edit[i].Attributes["OnClick"] = "DeleteKartItems(" + cin.Id + ",\"EditItem\");return false";


				edit[i].Attributes.Add("class", "delete");
				n1.Controls.Add(new LiteralControl(cin.Name));
				n2.Controls.Add(new LiteralControl(cin.Age.ToString()));
				n3.Controls.Add(new LiteralControl(cin.Email));
				n4.Controls.Add(new LiteralControl(cin.Address));
				n5.Controls.Add(delete[i]);
				n5.Controls.Add(edit[i]);
				i++;
				r.Cells.Add(n1);
				r.Cells.Add(n2);
				r.Cells.Add(n3);
				r.Cells.Add(n4);
				r.Cells.Add(n5);
				Table1.Rows.Add(r);

			}
			

		}


		[WebMethod]
		public static string DeleteItem(int id)
		{
			CustomerDetails c=cList.Find(x => x.Id == id);
			cList.Remove(c);
			return "Deleted Succesfully";

		}
		[WebMethod]
		public static string EditItem(int id)
		{
			CustomerDetails c = cList.Find(x => x.Id == id);
			cList.Remove(c);
			return "Edited Succesfully";

		}

	}
}
