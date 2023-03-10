<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mat-khau-moi.aspx.cs" Inherits="NHST.mat_khau_moi" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html>
<html class="loading" lang="en" data-textdirection="ltr">
<!-- BEGIN: Head-->
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui">
    <meta name="description" content="Materialize is a Material Design Admin Template,It's modern, responsive and based on Material Design by Google.">
    <meta name="keywords" content="materialize, admin template, dashboard template, flat admin template, responsive admin template, eCommerce dashboard, analytic dashboard">
    <meta name="author" content="ThemeSelect">
    <title>User Login</title>
    <link rel="apple-touch-icon" href="App_Themes/AdminNew45/assets/images/favicon/apple-touch-icon-152x152.png">
    <link rel="shortcut icon" type="image/x-icon" href="App_Themes/AdminNew45/assets/images/favicon/favicon.ico">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <!-- BEGIN: VENDOR CSS-->
    <link rel="stylesheet" type="text/css" href="App_Themes/AdminNew45/assets/vendors/vendors.min.css">
    <!-- END: VENDOR CSS-->
    <!-- BEGIN: Page Level CSS-->
    <link rel="stylesheet" type="text/css" href="App_Themes/AdminNew45/assets/css/materialize.css">
    <link rel="stylesheet" type="text/css" href="App_Themes/AdminNew45/assets/css/style.css">
    <link rel="stylesheet" type="text/css" href="App_Themes/AdminNew45/assets/css/pages/login.css">
    <link href="/App_Themes/NewUI/js/sweet/sweet-alert.css" rel="stylesheet" type="text/css" />
    <!-- END: Page Level CSS-->
    <!-- BEGIN: Custom CSS-->
    <link rel="stylesheet" type="text/css" href="App_Themes/AdminNew45/assets/css/custom/custom.css">
    <!-- END: Custom CSS-->
</head>
<!-- END: Head-->
<body class="horizontal-layout page-header-light horizontal-menu 1-column login-bg  blank-page blank-page" data-open="click" data-menu="horizontal-menu" data-col="1-column">
    <div class="row">
        <div class="col s12">
            <div class="container">
                <div id="login-page" class="row">
                    <div class="col s12 m6 l4 z-depth-4 card-panel border-radius-6 login-card bg-opacity-8">
                        <form runat="server" class="login-form">
                            <asp:ScriptManager runat="server" ID="scr">
                            </asp:ScriptManager>
                            <div class="row">
                                <div class="input-field col s12">
                                    <h5 class="ml-4">Tạo mật khẩu mới</h5>
                                </div>
                            </div>
                            <div class="row margin">
                                <div class="input-field col s12">
                                    <i class="material-icons prefix">lock_outline</i>
                                    <asp:TextBox runat="server" placeholder="Mật khẩu mới" ID="txtpass" type="password"></asp:TextBox>
                                    <span class="help-text">
                                        <asp:RequiredFieldValidator ID="rq" runat="server" ControlToValidate="txtpass" Display="Dynamic" ForeColor="Red" ErrorMessage="Không được để trống."></asp:RequiredFieldValidator>
                                    </span>
                                </div>
                            </div>
                            <div class="row margin">
                                <div class="input-field col s12">
                                    <i class="material-icons prefix">lock_outline</i>
                                    <asp:TextBox runat="server" placeholder="Xác nhận mật khẩu" ID="txtconfirmpass" type="password"></asp:TextBox>
                                    <span class="help-text">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="txtconfirmpass" ForeColor="Red" ErrorMessage="Không được để trống."></asp:RequiredFieldValidator>
                                        <br />
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ForeColor="Red" Display="Dynamic" ErrorMessage="Không trùng với mật khẩu." ControlToCompare="txtpass" ControlToValidate="txtconfirmpass"></asp:CompareValidator>
                                    </span>
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-field col s12">
                                    <a class="btn waves-effect waves-light border-round bg-dark-gradient col s12" onclick="Confirm()">Xác nhận</a>
                                </div>
                            </div>
                            <asp:Button ID="btncreateuser" runat="server" Text="Xác nhận" UseSubmitBehavior="false" Style="display: none"
                                OnClick="btncreateuser_Click" />


                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        function Confirm() {
            $('#<%=btncreateuser.ClientID%>').click();
        }
    </script>
    <!-- BEGIN VENDOR JS-->
    <script src="App_Themes/AdminNew45/assets/js/vendors.min.js" type="text/javascript"></script>
    <script src="/App_Themes/NewUI/js/sweet/sweet-alert.js" type="text/javascript"></script>
    <!-- BEGIN VENDOR JS-->
    <!-- BEGIN PAGE VENDOR JS-->
    <!-- END PAGE VENDOR JS-->
    <!-- BEGIN THEME  JS-->
    <script src="App_Themes/AdminNew45/assets/js/plugins.js" type="text/javascript"></script>
    <!-- END THEME  JS-->
    <!-- BEGIN PAGE LEVEL JS-->
    <!-- END PAGE LEVEL JS-->

</body>
</html>