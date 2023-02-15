<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_Banner.ascx.cs" Inherits="NHST.UC.uc_Banner" %>



<div class="banner">
    <!-- <div class="sticky">
                <div class="all">
                    <ul class="stick-announ">
                        <li class="announ__item">Businesses often become known</li>
                        <li class="announ__item">Businesses often become known today through effective marketing.</li>
                        <li class="announ__item">Businesses often become known today through effective marketing. The
                            marketing...
                        </li>
                    </ul>
                </div>
            </div> -->
    <div class="all">
        <div class="banner-content">
            <div class="bn__header">
                <h1 class="hd">HÀI LÒNG KHÁCH HÀNG
                                <br>
                    TẠO DỰNG UY TÍN
                </h1>
            </div>
            <span class="line-br"></span>
            <div class="addon-button">
                <p class="button-title">Cài đặt công cụ</p>
                <a href="" class="mn-btn gg-btn"><i class="fab fa-chrome"></i>Chrome</a>
                <a href="" class="mn-btn cc-btn"><i class="fab fa-chrome"></i>Cốc cốc</a>
            </div>
        </div>
    </div>
    <div class="search">
        <div class="all">
            <div class="search-wrap">
                <div class="search-title">
                    <h2 class="hd active" step-nav="#search">Tìm kiếm sản phẩm</h2>
                    <span>&nbsp;/&nbsp;</span>
                    <h2 class="hd" step-nav="#tracking">Tracking</h2>
                </div>
                <div class="search-form-wrap">
                    <div id="search" class="search-form">
                        <div class="select-form">
                            <select class="f-control" name="" id="brand-source">
                                <option value="taobao">TAOBAO</option>
                                <option value="tmall">Tmall</option>
                                <option value="1688">1688</option>
                            </select>
                            <span class="icon"><i class="fas fa-angle-down"></i></span>
                        </div>
                        <div class="input-form">
                            <%--<input type="text" class="f-control" placeholder="Nhập link sản phẩm">
                            <a href="" class="submit"><i class="fas fa-search"></i></a>--%>

                            <asp:TextBox ID="txtSearch" runat="server" CssClass="f-control txtsearchfield"
                                placeholder="Tìm kiếm sản phẩm"></asp:TextBox>
                            <a href="javascript:;" onclick="searchProduct()"
                                class="submit"><i class="fas fa-search"></i></a>
                            <asp:Button ID="btnSearch" runat="server"
                                OnClick="btnSearch_Click" Style="display: none"
                                OnClientClick="document.forms[0].target = '_blank';" UseSubmitBehavior="false" />

                        </div>
                    </div>
                    <div id="tracking" class="search-form">
                        <div class="input-form">
                            <%--<input type="text" class="f-control" placeholder="Nhập link sản phẩm">
                            <a href="" class="submit"><i class="fas fa-search"></i></a>--%>

                            <input id="txtMVD" type="text" class="f-control input"
                                placeholder="Mời nhập mã vận đơn">
                            <a href="javascript:;" onclick="searchCode()"
                                class="submit"><i class="fas fa-search"></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<asp:HiddenField ID="hdfWebsearch" runat="server" />
<script type="text/javascript">
    $(document).ready(function () {
        $('.txtsearchfield').on("keypress", function (e) {
            if (e.keyCode == 13) {
                searchProduct();
            }
        });
    });

    function searchProduct() {
        var web = $("#brand-source").val();
        $("#<%=hdfWebsearch.ClientID%>").val(web);
        $("#<%=btnSearch.ClientID%>").click();
    }
    function searchCode() {
        var code = $("#txtMVD").val();
        if (isEmpty(code)) {
            alert('Vui lòng nhập mã vận đơn.');
        }
        else {
            $.ajax({
                type: "POST",
                url: "/theo-doi-mvd.aspx/getInfo",
                data: "{ordecode:'" + code + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    if (msg.d != "null") {
                        //var data = JSON.parse(msg.d);
                        var title = "Thông tin mã vận đơn";
                        var content = msg.d;
                        var email = "";
                        var obj = $('form');
                        $(obj).css('overflow', 'hidden');
                        $(obj).attr('onkeydown', 'keyclose_ms(event)');
                        var bg = "<div id='bg_popup_home'></div>";
                        var fr = "<div id='pupip_home' class=\"columns-container1\">" +
                                 "  <div class=\"center_column col-xs-12 col-sm-5\" id=\"popup_content_home\">";
                        fr += "<div class=\"popup_header\">";
                        fr += title;
                        fr += "<a style='cursor:pointer;right:5px;' onclick='close_popup_ms()' class='close_message'></a>";
                        fr += "</div>";
                        fr += "     <div class=\"changeavatar\">";
                        fr += "         <div class=\"content1\" style=\"width:75%;margin-left:11%\">";
                        fr += content;
                        fr += "         </div>";
                        fr += "         <div class=\"content2\">";
                        fr += "             <a href=\"javascript:;\" class=\"btn btn-close\" onclick='close_popup_ms()'>Đóng</a>";
                        fr += "         </div>";
                        fr += "     </div>";
                        fr += "<div class=\"popup_footer\">";
                        fr += "<span class=\"float-right\">" + email + "</span>";
                        fr += "</div>";
                        fr += "   </div>";
                        fr += "</div>";
                        $(bg).appendTo($(obj)).show().animate({ "opacity": 0.7 }, 800);
                        $(fr).appendTo($(obj));
                        setTimeout(function () {
                            $('#pupip').show().animate({ "opacity": 1, "top": 20 + "%" }, 200);
                            $("#bg_popup").attr("onclick", "close_popup_ms()");
                        }, 1000);
                    }
                },
                error: function (xmlhttprequest, textstatus, errorthrow) {
                    alert('lỗi');
                }
            });
        }
    }

    function keyclose_ms(e) {
        if (e.keyCode == 27) {
            close_popup_ms();
        }
    }
    function close_popup_ms() {
        $("#pupip_home").animate({ "opacity": 0 }, 400);
        $("#bg_popup_home").animate({ "opacity": 0 }, 400);
        setTimeout(function () {
            $("#pupip_home").remove();
            $(".zoomContainer").remove();
            $("#bg_popup_home").remove();
            $('body').css('overflow', 'auto').attr('onkeydown', '');
        }, 500);
    }
    function closeandnotshow() {
        $.ajax({
            type: "POST",
            url: "/Default.aspx/setNotshow",
            //data: "{ID:'" + id + "',UserName:'" + username + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (msg) {
                close_popup_ms();
            },
            error: function (xmlhttprequest, textstatus, errorthrow) {
                alert('lỗi');
            }
        });
    }
</script>
<style>
    #bg_popup_home {
        position: fixed;
        width: 100%;
        height: 100%;
        background-color: #333;
        opacity: 0.7;
        filter: alpha(opacity=70);
        left: 0px;
        top: 0px;
        z-index: 999999999;
        opacity: 0;
        filter: alpha(opacity=0);
    }

    #popup_ms_home {
        background: #fff;
        border-radius: 0px;
        box-shadow: 0px 2px 10px #fff;
        float: left;
        position: fixed;
        width: 735px;
        z-index: 10000;
        left: 50%;
        margin-left: -370px;
        top: 200px;
        opacity: 0;
        filter: alpha(opacity=0);
        height: 360px;
    }

        #popup_ms_home .popup_body {
            border-radius: 0px;
            float: left;
            position: relative;
            width: 735px;
        }

        #popup_ms_home .content {
            /*background-color: #487175;     border-radius: 10px;*/
            margin: 12px;
            padding: 15px;
            float: left;
        }

        #popup_ms_home .title_popup {
            /*background: url("../images/img_giaoduc1.png") no-repeat scroll -200px 0 rgba(0, 0, 0, 0);*/
            color: #ffffff;
            font-family: Arial;
            font-size: 24px;
            font-weight: bold;
            height: 35px;
            margin-left: 0;
            margin-top: -5px;
            padding-left: 40px;
            padding-top: 0;
            text-align: center;
        }

        #popup_ms_home .text_popup {
            color: #fff;
            font-size: 14px;
            margin-top: 20px;
            margin-bottom: 20px;
            line-height: 20px;
        }

            #popup_ms_home .text_popup a.quen_mk, #popup_ms_home .text_popup a.dangky {
                color: #FFFFFF;
                display: block;
                float: left;
                font-style: italic;
                list-style: -moz-hangul outside none;
                margin-bottom: 5px;
                margin-left: 110px;
                -webkit-transition-duration: 0.3s;
                -moz-transition-duration: 0.3s;
                transition-duration: 0.3s;
            }

                #popup_ms_home .text_popup a.quen_mk:hover, #popup_ms_home .text_popup a.dangky:hover {
                    color: #8cd8fd;
                }

        #popup_ms_home .close_popup {
            background: url("/App_Themes/Camthach/images/close_button.png") no-repeat scroll 0 0 rgba(0, 0, 0, 0);
            display: block;
            height: 28px;
            position: absolute;
            right: 0px;
            top: 5px;
            width: 26px;
            cursor: pointer;
            z-index: 10;
        }

    #popup_content_home {
        height: auto;
        position: fixed;
        background-color: #fff;
        top: 15%;
        z-index: 999999999;
        left: 25%;
        border-radius: 10px;
        -moz-border-radius: 10px;
        -webkit-border-radius: 10px;
        width: 50%;
        padding: 20px;
    }

    #popup_content_home {
        padding: 0;
    }

    .popup_header, .popup_footer {
        float: left;
        width: 100%;
        background: #29aae1;
        padding: 10px;
        position: relative;
        color: #fff;
    }

    .popup_header {
        font-weight: bold;
        font-size: 16px;
        text-transform: uppercase;
    }

    .close_message {
        top: 10px;
    }

    .changeavatar {
        padding: 10px;
        margin: 5px 0;
        float: left;
        width: 100%;
    }

    .float-right {
        float: right;
    }

    .content1 {
        float: left;
        width: 100%;
    }

    .content2 {
        float: left;
        width: 100%;
        border-top: 1px solid #eee;
        clear: both;
        margin-top: 10px;
    }

    .btn.btn-close {
        float: right;
        background: #29aae1;
        color: #fff;
        margin: 10px 5px;
        text-transform: none;
        padding: 10px 20px;
    }

        .btn.btn-close:hover {
            background: #1f85b1;
        }

    .btn.btn-close-full {
        float: right;
        background: #7bb1c7;
        color: #fff;
        margin: 10px 5px;
        text-transform: none;
        padding: 10px 20px;
    }

        .btn.btn-close-full:hover {
            background: #6692a5;
        }

    .fr {
        float: right;
    }

    .fl {
        float: left;
    }

    .side {
        /*float: left;
        width: 100%;
        clear: both;*/
        padding-left: 1%;
    }

    .trk-info {
        font-size: 16px;
        margin-bottom: 20px;
    }

    .it {
        padding-bottom: 30px;
        position: relative;
    }

    .list {
        list-style: none;
    }

    li.it {
        list-style: none;
    }

    .it:before {
        content: '';
        border-left: 1px solid #e1e1e1;
        width: 1px;
        height: 76px;
        position: absolute;
        top: 0;
        left: 155px;
    }

    .trk-history .date-time {
        width: 140px;
        float: left;
    }

    .statuss {
        float: right;
        width: calc(100% - 140px);
        width: -webkit-calc(100% - 140px);
        position: relative;
        padding-left: 50px;
        font-size: 16px;
    }

        .statuss .ico {
            display: block;
            width: 30px;
            height: 30px;
            line-height: 30px;
            border: 1px solid #707070;
            background: #fff;
            text-align: center;
            border-radius: 50%;
            position: absolute;
            top: 0;
            left: 0;
            color: #707070;
        }

        .statuss.ok .ico {
            color: #8dc63f;
            border-color: #8dc63f;
        }

    .fa-check:before {
        content: "\f00c";
    }

    .clear:after, .all:after, .collapse .collapse-heading:after, .collapse .collapse-body:after, #header:after, #main-wrap:after, #footer:after, .quick-order-box .form-row:after {
        content: "";
        display: table;
        clear: both;
    }

    .m-color {
        color: #f36f21;
    }

    .tracking-btn:hover {
        background: #496872;
    }

    .submit-form {
        line-height: 10px;
        padding: 10px;
        border-radius: 20px;
        background-color: #fa4659;
        color: #fff;
        z-index: 1;
        text-decoration: none;
        font-weight: bold;
        float: left;
        text-align: center;
        transition: .15s;
        margin-top: 5px;
        margin-right: 5px;
    }
</style>






<%--<div class="group-banner">
    <div class="banner-entry wow fadeInUp">
        <div class="all">
            <h3 class="title">Chúng tôi</h3>
            <h3 class="desc">CHUYÊN CHUNG CẤP DỊCH VỤ<br>
                ORDER & VẬN CHUYỂN HÀNG HÓA<br>
                TRUNG QUỐC - VIỆT NAM</h3>
            <p class="content" style="display:none">
                You have finished building your own website. You have introduced your company and<br>
                presented your products and services.
            </p>
            <span class="border-bot-title"></span>
            <div class="group-tool">
                <div class="tool-item">
                    <a href="https://chrome.google.com/webstore/detail/công-cụ-đặt-hàng-vận-tải/hifcebcgmjnfhjdkjdjnflbcfngilpfc" target="_blank"><span class="icon"><i class="fa fa-chrome"></i></span>CHROME</a>
                    <a href="https://chrome.google.com/webstore/detail/công-cụ-đặt-hàng-vận-tải/hifcebcgmjnfhjdkjdjnflbcfngilpfc" target="_blank"><span class="icon"><i class="fa fa-chrome"></i></span>CỐCCỐC</a>
                </div>
            </div>
        </div>
    </div>
    <div class="banner-home">
        <div class="banner" style="background-image: url(/App_Themes/vantaihoakieu/images/banner.jpg);">
        </div>
        <%--<div class="banner" style="background-image: url(/App_Themes/vantaihoakieu/images/banner.jpg);">
                </div>--%>
    </div>
</div>--%>
