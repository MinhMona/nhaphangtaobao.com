<%@ Page Language="C#" MasterPageFile="~/manager/adminMasterNew.Master" AutoEventWireup="true" CodeBehind="Customer-Feedback.aspx.cs" Inherits="NHST.manager.Customer_Feedback" %>


<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Import Namespace="NHST.Controllers" %>
<%@ Import Namespace="NHST.Models" %>
<%@ Import Namespace="NHST.Bussiness" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="main" class="main-full">
        <div class="row">
            <div class="content-wrapper-before bg-dark-gradient"></div>
            <div class="page-title">
                <div class="card-panel">
                    <h4 class="title no-margin" style="display: inline-block;">Khách nói gì về chúng tôi</h4>
                    <div class="right-action">
                        <a href="#modalEditStep" class="modal-trigger btn">Thêm</a>
                    </div>
                    <div class="clearfix"></div>
                </div>

              
            </div>
            <div class="list-donate-money col s12 section">
                <div class="list-table card-panel">
                    <div class="filter">
                        <div class="clearfix"></div>
                    </div>
                    <div class="responsive-tb mt-2">
                        <table class="table responsive-table  bordered highlight  ">
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>Họ tên</th>
                                    <th>IMG</th>
                                    <th>Trạng thái</th>
                                    <th>Ngày tạo</th>
                                    <th>Thao tác</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Literal ID="ltr" runat="server" EnableViewState="false"></asp:Literal>
                            </tbody>
                        </table>
                    </div>
                    <div class="pagi-table float-right mt-2">
                        <%this.DisplayHtmlStringPaging1();%>
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="bg-overlay"></div>
            <!-- add mode -->
            <div id="modalEditStep" class="modal modal-fixed-footer">
                <div class="modal-hd">
                    <span class="right"><i class="material-icons modal-close right-align">clear</i></span>
                    <h4 class="no-margin center-align">Thêm thông tin</h4>
                </div>
                <div class="modal-bd">
                    <div class="row">
                        <div class="input-field col s12">
                            <asp:TextBox runat="server" ID="txtFullName" placeholder="" type="text" class="validate" data-type="text-only"></asp:TextBox>
                            <label class="active" for="edit__step-name">Họ tên</label>
                        </div>

                        <div class="input-field col s12">
                            <span class="black-text">Hình ảnh</span>
                            <div style="display: inline-block; margin-left: 15px;">
                                <asp:FileUpload runat="server" ID="TeamIMG" class="upload-img" type="file" onchange="previewFiles(this);" title=""></asp:FileUpload>
                                <button class="btn-upload">Upload</button>
                            </div>
                            <div class="preview-img">
                                <asp:Image ID="EditIMGBefore" runat="server" />
                            </div>
                        </div>

                        <div class="input-field col s12">
                            <asp:TextBox runat="server" placeholder="" ID="txtDescription" class="materialize-textarea" TextMode="MultiLine"></asp:TextBox>
                            <label class="active">Mô tả ngắn</label>
                        </div>
                    </div>
                </div>
                <div class="modal-ft">
                    <div class="ft-wrap center-align">
                        <a id="BtnUpStep" onclick="btnUpStep()" class="modal-action btn modal-close waves-effect waves-green mr-2">Thêm</a>
                        <a href="#!" class="modal-action btn orange darken-2 modal-close waves-effect waves-green ml-2">Hủy</a>
                    </div>
                </div>
            </div>
            <!-- END : Edit mode -->

            <!-- add mode -->
            <div id="modalEdit" class="modal modal-fixed-footer">
                <div class="modal-hd">
                    <span class="right"><i class="material-icons modal-close right-align">clear</i></span>
                    <h4 class="no-margin center-align">Thông tin</h4>
                </div>
                <div class="modal-bd">
                    <div class="row">
                        <div class="input-field col s12">
                            <asp:TextBox runat="server" ID="EditFullName" placeholder="" type="text" class="validate" data-type="text-only"></asp:TextBox>
                            <label class="active" for="edit__step-name">Họ tên</label>
                        </div>

                        <div class="input-field col s12">
                            <span class="black-text">Hình ảnh</span>
                            <div style="display: inline-block; margin-left: 15px;">
                                <asp:FileUpload runat="server" ID="EditIMG" class="upload-img" type="file" onchange="previewFiles(this);" title=""></asp:FileUpload>
                                <button class="btn-upload">Upload</button>
                            </div>
                            <div class="preview-img">
                                <asp:Image ID="ImgBefore" runat="server" />
                            </div>
                        </div>

                        <div class="input-field col s12">
                            <asp:TextBox runat="server" placeholder="" ID="EditDescription" class="materialize-textarea" TextMode="MultiLine"></asp:TextBox>
                            <label class="active">Mô tả ngắn</label>
                        </div>
                        <div class="input-field col s12">
                            <div class="switch status-func">
                                <span class="mr-2">Trạng thái: </span>
                                <label>
                                    Ẩn
                    <asp:TextBox runat="server" ID="EditStatus" onclick="StatusFunction()" type="checkbox"></asp:TextBox>
                                    <span class="lever"></span>
                                    Hiện
                                </label>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-ft">
                    <div class="ft-wrap center-align">
                        <a id="btnEdit" onclick="Update()" class="modal-action btn modal-close waves-effect waves-green mr-2">Cập nhật</a>
                        <a href="#!" class="modal-action btn orange darken-2 modal-close waves-effect waves-green ml-2">Hủy</a>
                    </div>
                </div>
            </div>
            <!-- END : Edit mode -->

           

          


        </div>
    </div>
    <div id="printcontent" style="display: none">
    </div>
    <asp:HiddenField runat="server" ID="hdfIDHSW" />
    <asp:HiddenField ID="hdfEditStatus" runat="server" Value="0" />
    <asp:HiddenField ID="hdfID" runat="server" Value="0" />
    <asp:Button runat="server" ID="btnSaveEdit" OnClick="btncreateuser_Click" Style="display: none" UseSubmitBehavior="false" />
    <asp:Button runat="server" ID="btnUpdate" OnClick="btnUpdate_Click" Style="display: none" UseSubmitBehavior="false" />
    <asp:Button runat="server" ID="btnDelete" onclick="btnDelete_Click" Style="display: none" UseSubmitBehavior="false" />
    <script type="text/javascript">

        function btnUpStep() {
            $('#<%=btnSaveEdit.ClientID%>').click();
        }

        function EditCustomer(ID) {
            $.ajax({
                type: "POST",
                url: "/manager/Customer-Feedback.aspx/loadinfo",
                data: '{ID: "' + ID + '"}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    var data = JSON.parse(msg.d);
                    if (data != null) {
                        $('#<%=EditFullName.ClientID%>').val(data.Name);
                        $('#<%=EditDescription.ClientID%>').val(data.Description);
                        $('#<%=ImgBefore.ClientID%>').attr("src", data.IMG);
                        var a = data.Hide;
                        if (a == false) {
                            $('#<%=EditStatus.ClientID%>').prop('checked', true);
                            $('#<%=hdfEditStatus.ClientID%>').val('0');
                        }
                        else {
                            $('#<%=EditStatus.ClientID%>').prop('checked', false);
                            $('#<%=hdfEditStatus.ClientID%>').val('1');
                        }
                        $('#<%=hdfID.ClientID%>').val(data.ID);
                        $('select').formSelect();
                    }
                    else
                        swal("Error", "Không thành công", "error");
                },
                error: function (xmlhttprequest, textstatus, errorthrow) {
                    swal("Error", "Fail updateInfoAcc", "error");
                }
            });
        }

        function StatusFunction() {
            var a = $('#<%=hdfEditStatus.ClientID%>').val();
            if (a == '0') {

                $('#<%=hdfEditStatus.ClientID%>').val('1');
              }
              else {

                  $('#<%=hdfEditStatus.ClientID%>').val('0');
            }
        }

        function Update() {
            $("#<%=btnUpdate.ClientID%>").click();
        }
        function Delete(ID) {
            var c = confirm('bạn có muốn xóa không?');
            if (c) {
                $("#<%=hdfID.ClientID%>").val(ID);
                $("#<%=btnDelete.ClientID%>").click();
            }
        }
      
    </script>

</asp:Content>
