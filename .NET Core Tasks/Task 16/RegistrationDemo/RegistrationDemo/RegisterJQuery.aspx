<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterJQuery.aspx.cs" Inherits="RegistrationDemo.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script src="lib/jquery/jquery.js"></script>
    <script src="lib/jquery-validate/jquery.validate.js"></script>
    <script src="lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"></script>
    <p>
        <br />
    </p>

    <p style="font-size: xx-large">
        Registration Form Using JQuery
    </p>


    <p>
        &nbsp;</p>
    <p>
        <label for="name">Name</label>
        <input id="name" name="name" type="text">
    </p>
    <p>
        <label for="email">E-Mail</label>
        <input id="email" type="email" name="email">
    </p>
    <p>
        <label for="phone">Phone</label>
        <input id="phone" type="phone" name="phone">
    </p>
    <p>
        <label for="url">URL</label>
        <input id="url" type="url" name="url">
    </p>
    <p>
        <label for="username">Username</label>
        <input id="username" name="username" type="text">
    </p>
    <p>
        <label for="password">Password</label>
        <input id="password" name="password" type="password">
    </p>
    <p>
        <label for="confirm_password">Confirm password</label>
        <input id="confirm_password" name="confirm_password" type="password">
    </p>
    <p>
        <label for="agree">Please agree to our policy</label>
        <input type="checkbox" class="checkbox" id="agree" name="agree">
    </p>
    <p>
        <input class="submit" type="submit" value="Submit">
    </p>
    <script>
        $(document).ready(function () {
            $("#masterForm").validate({
                rules: {
                    name: "required",
                    email: {
                        required: true,
                        email: true
                    },
                    phone: {
                        required: true,
                        number: true
                    },
                    url: {
                        required: false,
                        url: true
                    },
                    username: {
                        required: true,
                        minlength: 6
                    },
                    password: {
                        required: true,
                        minlength: 6
                    },
                    confirm_password: {
                        required: true,
                        minlength: 6,
                        equalTo: "#password"
                    },
                    agree: "required"
                },
                messages: {
                    name: "Please enter your name",
                    email: "Please enter a valid email address",
                    phone: {
                        required: "Please enter your phone number",
                        number: "Please enter only numeric value"
                    },
                    url: {
                        url: "Please enter valid url"
                    },
                    username: {
                        required: "Please enter a username",
                        minlength: "Your username must consist of at least 6 characters"
                    },
                    password: {
                        required: "Please provide a password",
                        minlength: "Your password must be at least 6 characters long"
                    },
                    confirm_password: {
                        required: "Please provide a password",
                        minlength: "Your password must be at least 6 characters long",
                        equalTo: "Please enter the same password as above"
                    },
                    agree: "Please accept our policy"
                }
            });
        });
    </script>

</asp:Content>
