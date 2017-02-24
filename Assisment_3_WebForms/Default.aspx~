<%@ Page Language="C#" Inherits="Assisment_3_WebForms.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
		<script src="jquery-1.10.2.min.js" type="text/javascript">
			
		</script>
</head>
<body>
	<form id="form1" runat="server">
			<asp:ScriptManager ID="ScriptMgr" runat="server" EnablePageMethods="true"></asp:ScriptManager>
			<table cellspacing="10">
				<tr>
					<td>Name:</td>
					<td><asp:TextBox ID="name" placeholder="Name" runat="server" ></asp:TextBox></td>
				</tr>
				<tr>
					<td>Age:</td>
					<td><asp:TextBox ID="age" placeholder="18+"  runat="server" ></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td>E-Mail:</td>
					<td><asp:TextBox ID="email" placeholder="example@gmail.com" runat="server" ></asp:TextBox></td>
				</tr>
				<tr>
					<td>Address:</td>
					<td><asp:TextBox ID="address" placeholder="Home" TextMode="multiline" Columns="25" Rows="4" runat="server" ></asp:TextBox></td>
				</tr>
				<tr>
					<td><asp:Button id="submit" runat="server" Text="Click me!" OnClick="OnSubmit" /></td>
					<td><asp:Button id="details" runat="server" Text="Click me!" OnClick="OnDetails" /></td>

				</tr>
			</table>
			<div>
					<asp:Table ID="Table1" runat="server" Height="114" Width="439" >
           				
            			<asp:TableRow> 
							<asp:TableCell>
								
							</asp:TableCell>
								
						</asp:TableRow>
        			</asp:Table>
				
			</div>
			<div id="sss">
			</div>
			
	</form>
</body>
</html>
<script type="text/javascript">             
       
	function DeleteKartItems(id,eod) {


		
	alert(id);
     $.ajax({

            url: "/Default.aspx/"+eod,
            data: { "id": id },
            type: "GET",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (mydata) {

                alert(mydata.d);
            }
        });
	}
	</script>