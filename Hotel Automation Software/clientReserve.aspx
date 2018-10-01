<%@ Page Title="" Language="C#" MasterPageFile="~/Hotel.Master" AutoEventWireup="true" CodeBehind="clientReserve.aspx.cs" Inherits="Hotel_Automation_Software.clientReserve" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
    
      <div class="row">
        <div class="input-field col s6">
          <asp:Label runat="server" ID="lbl1"><b>First Name</b></asp:Label>
          <asp:TextBox runat="server" ID="first_name"  Cssclass="validate"/>
          <asp:RequiredFieldValidator ID="fname" ControlToValidate="first_name" runat="server" ErrorMessage="Mandatory Field" Display="Dynamic">
          </asp:RequiredFieldValidator>
        </div>

        <div class="input-field col s6">
          <asp:Label runat="server" ID="Label2"><b>Last Name</b></asp:Label>
          <asp:TextBox runat="server" ID="last_name"  Cssclass="validate"/>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="last_name" runat="server" ErrorMessage="Mandatory Field" Display="Dynamic">
          </asp:RequiredFieldValidator>
          
        </div>
        
      </div>
        <hr/>
     <div class="row">
         &nbsp;&nbsp;&nbsp;
         <asp:Label runat="server" ID="Label3"><b>Choose Date</b></asp:Label>
         <br />
         <br /><b>
         <asp:Calendar runat="server" ID="cal" Width="350px" Height="190px" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" NextPrevFormat="FullMonth">
             <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
             <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
             <OtherMonthDayStyle ForeColor="#999999" />
             <SelectedDayStyle BackColor="#333399" ForeColor="White" />
             <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
             <TodayDayStyle BackColor="#CCCCCC" />
         </asp:Calendar>
         </b> 
     </div>

     <hr/>
         &nbsp;&nbsp;

     
         <asp:Label runat="server" ID="Label4"><b>Type of Room</b></asp:Label>
         <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem Text="Non-AC Double" Value="nacd"></asp:ListItem>
            <asp:ListItem Text="AC Double" Value="acd"></asp:ListItem>
            <asp:ListItem Text="Non-Ac Single" Value="nacs"></asp:ListItem>
            <asp:ListItem Text="AC Single" Value="acs"></asp:ListItem>
        </asp:CheckBoxList>
       
        <br />
        <hr/>
         <br />
        <div class="row">
        &nbsp;
        
        <asp:Label runat="server" ID="lbl_noroom" ><b>Number of Rooms</b></asp:Label>
        <asp:TextBox runat="server" ID="no_of_rooms" />
        <asp:RangeValidator runat="server" ID="range" ControlToValidate="no_of_rooms" MinimumValue="1" MaximumValue="10" Display="Dynamic" Type="Integer" ErrorMessage="Minimum 1 day stay">
            </asp:RangeValidator>
        
        </div>
        
        
      <asp:Button Cssclass="btn waves-effect waves-light" text="Submit" ID="submit_btn" runat="server" OnClick="submit_reservation"/>
        <br />
    <br />
        
    </div>
   
          <asp:Label ID="lblerr" runat="server" Text=""/>

</asp:Content>
