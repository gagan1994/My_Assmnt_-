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
					<td><asp:Button id="submit" runat="server" Text="Submit" OnClick="OnSubmit" /></td>
					<td><asp:Button id="details" runat="server" Text="Details" OnClick="OnDetails" /></td>

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

			
	</form>
	<div class="editDiv" >
			<form id="form2" runat="server">
			<table cellspacing="10">
				<tr>
					<td>Name:</td>
					<td><asp:TextBox ID="ename" placeholder="Name" runat="server" ></asp:TextBox></td>
						<td><asp:TextBox ID="eId" placeholder="id"  runat="server" ReadOnly ></asp:TextBox></td>
				</tr>
				<tr>
					<td>Age:</td>
					<td><asp:TextBox ID="eage" placeholder="18+"  runat="server" ></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td>E-Mail:</td>
					<td><asp:TextBox ID="eemail" placeholder="example@gmail.com" runat="server" ></asp:TextBox></td>
				</tr>
				<tr>
					<td>Address:</td>
					<td><asp:TextBox ID="eaddress" placeholder="Home" TextMode="multiline" Columns="25" Rows="4" runat="server" ></asp:TextBox></td>
				</tr>
				<tr>
					<td><asp:Button  Class="save" runat="server" id="save" Text="Save" OnClick="OnSave" /></td>

				</tr>
			</table>
		</form>	
		</div>
		
		
</body>
</html>
<script type="text/javascript">     


	
      $(document).ready(function (){
      $("#save").click(function (){
		alert("edited successfully");
       location.reload();
	});
      $(".editDiv").hide();
	});
	
	function DeleteKartItems(id,eod) {
	var s=" edit ";
	if(eod==="DeleteItem"){
		s=" delete ";
	}
		
	
	var res = confirm("Are you sure you want to"+ s +"this item?");

	if(res)
     	$.ajax({

            url: "/Default.aspx/"+eod,
            data: { "id": id },
            type: "GET",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (mydata) {
            	if(eod==="DeleteItem"){
				alert("deleted successfully");
				location.reload();
				}else{
					$(".editDiv").show();
					$("#ename").val(mydata.d.Name);
					$("#eage").val(mydata.d.Age);
					$("#eemail").val(mydata.d.Email);
					$("#eaddress").val(mydata.d.Address);
					$("#eId").val(mydata.d.Id);
               		}
				
            	}
        	});
	}
	</script>