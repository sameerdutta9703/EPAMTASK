<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RegistrationDemo.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    &nbsp;</p>
<p style="font-size: xx-large">
    Registration Form
</p>
<p>
    &nbsp;</p>
<p>
    First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="201px"></asp:TextBox>
</p>
<p>
    Last Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="24px" Width="201px"></asp:TextBox>
</p>
<p>
    Mobile Number&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="24px" Width="201px"></asp:TextBox>
</p>
<p>
    Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Height="24px" Width="201px"></asp:TextBox>
</p>
<p>
    Country&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="206px" DataSourceID="SqlDataSource2" DataTextField="County" DataValueField="CountryId" AutoPostBack="true">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:RegisterDBConnectionString %>" SelectCommand="SELECT [CountryId], [County] FROM [Country]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</p>
<p>
    State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList4" runat="server" Height="22px" Width="206px" DataSourceID="SqlDataSource3" DataTextField="State" DataValueField="StateId" AutoPostBack="true">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:RegisterDBConnectionString2 %>" SelectCommand="SELECT [StateId], [State] FROM [countryState] WHERE ([CountryId] = @CountryId)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="CountryId" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</p>
<p>
    City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList5" runat="server" Height="22px" Width="206px" DataSourceID="SqlDataSource4" DataTextField="City" DataValueField="CityId" AutoPostBack="true" >
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:RegisterDBConnectionString3 %>" SelectCommand="SELECT [CityId], [City] FROM [stateCity] WHERE ([StateId] = @StateId)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList4" Name="StateId" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</p>
<p>
    Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButtonList ID="GenderList" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        Stream&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>Dot Net</asp:ListItem>
            <asp:ListItem>Big Data</asp:ListItem>
            <asp:ListItem>DevOps</asp:ListItem>
        </asp:CheckBoxList>
    </p>
    <p>
        Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Height="24px" TextMode="Date" Width="201px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
</p>
<p>
</p>
<p>
    &nbsp;</p>
<p>
</p>
<p>
    &nbsp;</p>
</asp:Content>
