<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterJS.aspx.cs" Inherits="RegistrationDemo.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;
    </p>

    <p style="font-size: xx-large">
        Registration Form Using Javascrtipt
    </p>

    <p>
        &nbsp;
    </p>

    <p>
        First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="FNameText" runat="server" Height="24px" Width="201px"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="FNameText" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    </p>

    <p>
        Last Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="LNameText" runat="server" Height="24px" Width="201px"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="LNameText" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    </p>
    <p>
        Password &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="PasswordText" runat="server" Height="24px" Width="201px"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="PasswordText" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="rev1" runat="server"
            ControlToValidate="PasswordText"
            ErrorMessage="Minimum 8 characters atleast 1 Alphabet, 1 Number and 1 Special Character"
            ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$">
        </asp:RegularExpressionValidator>
    </p>

    <p>
        Mobile Number&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="MobileText" runat="server" Height="24px" Width="201px"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="MobileText" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
            ControlToValidate="MobileText" runat="server"
            ErrorMessage="Only Numbers allowed"
            ValidationExpression="\d+">
        </asp:RegularExpressionValidator>
    </p>

    <p>
        Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="EmailText" runat="server" TextMode="Email" Height="24px" Width="201px"></asp:TextBox>

        <asp:CustomValidator runat="server" ID="CustomValidatorEmail" EnableClientScript="true" ClientValidationFunction="ValidateRegForEmail()">You must select this box to proceed.</asp:CustomValidator>
    </p>

    <p>
        Country&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="CountryDropDownList" runat="server" Height="22px" Width="206px" DataSourceID="SqlDataSource2" DataTextField="County" DataValueField="CountryId" AutoPostBack="true">
    </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:RegisterDBConnectionString %>" SelectCommand="SELECT [CountryId], [County] FROM [Country]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

        <asp:CustomValidator runat="server" ID="CustomValidatorCountry" EnableClientScript="true" ClientValidationFunction="return(DropDownValidator())">You must select from this box to proceed.</asp:CustomValidator>
    </p>

    <p>
        State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:DropDownList ID="StateDropDownList" runat="server" Height="22px" Width="206px" DataSourceID="SqlDataSource3" DataTextField="State" DataValueField="StateId" AutoPostBack="true">
    </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:RegisterDBConnectionString2 %>" SelectCommand="SELECT [StateId], [State] FROM [countryState] WHERE ([CountryId] = @CountryId)">
            <SelectParameters>
                <asp:ControlParameter ControlID="CountryDropDownList" Name="CountryId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>

    <p>
        City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="CityDropDownList" runat="server" Height="22px" Width="206px" DataSourceID="SqlDataSource4" DataTextField="City" DataValueField="CityId" AutoPostBack="true">
    </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:RegisterDBConnectionString3 %>" SelectCommand="SELECT [CityId], [City] FROM [stateCity] WHERE ([StateId] = @StateId)">
            <SelectParameters>
                <asp:ControlParameter ControlID="StateDropDownList" Name="StateId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>

    <p>
        Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButtonList ID="GenderButtonList" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>

        <asp:CustomValidator runat="server" ID="RadioButtonvalidator" EnableClientScript="true" ClientValidationFunction="RadioRequired_ClientValidate()">You must select this box to proceed.</asp:CustomValidator>
    </p>

    <p>
        Stream&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:CheckBoxList ID="StreamCheckBoxList" runat="server">
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>Dot Net</asp:ListItem>
            <asp:ListItem>Big Data</asp:ListItem>
            <asp:ListItem>DevOps</asp:ListItem>
        </asp:CheckBoxList>

        <asp:CustomValidator runat="server" ID="CheckBoxRequired" EnableClientScript="true" ClientValidationFunction="CheckBoxRequired_ClientValidate()">You must select this box to proceed.</asp:CustomValidator>
    </p>

    <p>
        Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="DateTextBox" runat="server" Height="24px" TextMode="Date" Width="201px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DateTextBox" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    </p>

    <p>
        &nbsp;
    </p>

    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClientClick="ValidateAll();" OnClick="SubmitButton_Click" />
        &nbsp;
    </p>


    <!-- The Javascript file for the code for client side validation -->

    <script type="text/javascript">

        function ValidateAll() {

            ValidateRegForEmail();
            RadioRequired_ClientValidate();
            CheckBoxRequired_ClientValidate();
            DropDownValidator();

        }
        
        function ValidateRegForEmail() {
            var email = document.getElementById("<%=EmailText.ClientID%>");
            var filter = /^([a-zA-Z0-9_.-])+@(([a-zA-Z0-9-])+.)+([a-zA-Z0-9]{2,4})+$/;
            if (!filter.test(email.value)) {
                alert('Please provide a valid email address');
                email.focus;
                return false;
            }
            
        }

        
        function RadioRequired_ClientValidate() {
            var CHK = document.getElementById("<%=GenderButtonList.ClientID%>");
            var checkbox = CHK.getElementsByTagName("input");
            var label = CHK.getElementsByTagName("label");
            if (!checkbox[0].checked && !checkbox[1].checked) {
                alert("Gender field is required ");
                return false;
            }
        }

        
        function CheckBoxRequired_ClientValidate() {
            var CHK = document.getElementById("<%=StreamCheckBoxList.ClientID%>");
            var checkbox = CHK.getElementsByTagName("input");
            var label = CHK.getElementsByTagName("label");

            if (!checkbox[0].checked && !checkbox[1].checked && !checkbox[2].checked) {
                alert("Stream field is required ");
                return false;
            }
        }

        
        function DropDownValidator() {
            
            var ddlImageFormatVal = document.getElementById("<%=CountryDropDownList.ClientID%>").value;
            if (ddlImageFormatVal == 0) {
                alert("Country field is required.");
                return false;
            } else {
                return true;                
            }
            
        }
    </script>
</asp:Content>

