<%@ MasterType VirtualPath="Store.master" %>
<%@ Page Language="C#" AutoEventWireup="true" 
Inherits="System.Web.UI.Page" MasterPageFile="Store.master" %>
<%@ Import Namespace="nothinbutdotnetstore.web.application.catalogbrowsing" %>
<asp:Content ID="content" runat="server" ContentPlaceHolderID="childContentPlaceHolder">
    <p class="ListHead">Select An Department</p>

            <table>            
		<!-- for each of the main departments in the store -->
		<%
		    ViewMainDepartmentsResult data = (ViewMainDepartmentsResult) this.Context.Items["CommandResult"];
		foreach (var department in data.Departments)
{%>
        	<tr class="ListItem">
               		 <td>                     
<%=department.Name%>
                	</td>
           	 </tr>        
           	 <%  }  %>
	    </table>            
</asp:Content>
