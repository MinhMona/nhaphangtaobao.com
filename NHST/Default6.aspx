<%--<%@ Page Language="C#" MasterPageFile="~/DangTrangMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NHST.Default3" %>--%>

<%@ Page Language="C#" MasterPageFile="~/DangTrangMaster.Master" AutoEventWireup="true" CodeBehind="Default6.aspx.cs" Inherits="NHST.Default3" %>

<asp:Content runat="server" ContentPlaceHolderID="head"></asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <main class="main">
        <div class="banner-section sec" style="background-image: url(/App_Themes/DangTrang/images/banner.png);">
            <div class="container">
                <h1 class="banner-title">NhapHangTaoBao<br>
                    <i class="fa fa-caret-right" aria-hidden="true"></i>Vận chuyển nhanh chóng<br>
                    <i class="fa fa-caret-right" aria-hidden="true"></i>Nhập hàng Trung Quốc giá gốc<br>
                    <i class="fa fa-caret-right" aria-hidden="true"></i>Đặt hàng dễ dàng, chuyên nghiệp
                </h1>
                <div class="install-wrapper desktop-tools">
                    <p class="md-title">ĐẶT HÀNG TRÊN MÁY TÍNH</p>
                    <div class="btn-box">
                        <a href="https://chrome.google.com/webstore/detail/c%C3%B4ng-c%E1%BB%A5-%C4%91%E1%BA%B7t-h%C3%A0ng-dangtran/lllcafkpdjioabggogoliopfchfjmjlb" class="btn chrome-btn"><i class="fa fa-chrome" aria-hidden="true"></i> CHROME</a>
                        <a href="https://chrome.google.com/webstore/detail/c%C3%B4ng-c%E1%BB%A5-%C4%91%E1%BA%B7t-h%C3%A0ng-dangtran/lllcafkpdjioabggogoliopfchfjmjlb" class="btn coccoc-btn"><i class="fa fa-chrome" aria-hidden="true"></i>CỐC CỐC</a>
                    </div>
                </div>
                <div class="install-wrapper">
                    <p class="md-title">APP ĐẶT HÀNG TRÊN MOBILE</p>
                    <div class="btn-box">
                        <a href="#" class="btn">
                            <img src="/App_Themes/DangTrang/images/gg-play.png" alt=""></a>
                        <a href="#" class="btn">
                            <img src="/App_Themes/DangTrang/images/app-store.png" alt=""></a>
                    </div>
                </div>
            </div>
        </div>
        <section class="about-us-section sec">
            <div class="container">
                <div class="about-us-content">
                    <div class="about-us-top">
                        <div class="columns">
                            <div class="column left">
                                <h2 class="about-title">Chúng tôi cung cấp các dịch vụ vận chuyển hàng</h2>
                            </div>
                            <div class="column right">
                                <div class="search-tracking-tab-wrapper tab-wrapper">
                                    <ul class="search-tracking-tab-nav">
                                        <li class="tab-link current" data-tab="#search">TÌM KIẾM SẢN PHẨM</li>
                                        <li class="tab-link" data-tab="#tracking">TRA MÃ VẬN ĐƠN</li>
                                    </ul>
                                    <div class="search-tracking-tab-content">
                                        <div id="search" class="tab-content">
                                            <select name="" id="brand-source" class="f-control">
                                                <option value="tmall">tmall</option>
                                                <option value="1688">1688</option>
                                                <option value="taobao">Taobao</option>
                                            </select>
                                            <asp:TextBox runat="server" ID="txtSearch" class="f-control"  placeholder="Nhập link sản phẩm"></asp:TextBox>
                                            <a href="javascript:;" onclick="searchProduct()" class="main-btn main-btn-3">TÌM KIẾM</a>
                                           
                                            <asp:Button ID="btnSearch" runat="server"
                                                OnClick="btnSearch_Click" Style="display: none"
                                                OnClientClick="document.forms[0].target = '_blank';" UseSubmitBehavior="false" />
                                        </div>



                                        <div id="tracking" class="tab-content">
                                  
                                         <input id="txtMVD" type="text" class="f-control" placeholder="Nhập mã vận đơn">
                                            <div class="search-tracking-form">
                                                <a href="javascript:;" onclick="searchCode()" class="main-btn main-btn-3">Tracking</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="about-us-bottom">
                        <div class="columns">
                            <div class="column">
                                <div class="about-us-item">
                                    <div class="logo">
                                        <img src="/App_Themes/DangTrang/images/logo-1.png" alt="">
                                    </div>
                                    <div class="info">
                                        <p class="title">Khách hàng với Khách hàng</p>
                                        <div class="desc">Là hình thức thương mại điện tử giữa những người tiêu dùng với nhau</div>
                                    </div>
                                </div>
                            </div>
                            <div class="column">
                                <div class="about-us-item">
                                    <div class="logo">
                                        <img src="/App_Themes/DangTrang/images/logo-2.png" alt="">
                                    </div>
                                    <div class="info">
                                        <p class="title">Doanh nghiệp với khách hàng</p>
                                        <div class="desc">Là hình thức thương mại điện tử giữa những người tiêu dùng với nhau</div>
                                    </div>
                                </div>
                            </div>
                            <div class="column">
                                <div class="about-us-item">
                                    <div class="logo">
                                        <img src="/App_Themes/DangTrang/images/logo-3.png" alt="">
                                    </div>
                                    <div class="info">
                                        <p class="title">Doanh nghiệp với doanh nghiệp</p>
                                        <div class="desc">Là hình thức thương mại điện tử giữa những người tiêu dùng với nhau</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section class="procedure-section sec">
            <div class="container">
                <div class="columns">
                    <div class="column procedure-section-left">
                        <div class="main-title-box">
                            <h2 class="main-title">Quy trình đặt hàng</h2>
                        </div>
                    </div>
                    <div class="column procedure-section-right">
                        <div class="step-tab-wrapper tab-wrapper">
                            <ul class="step-tab-nav">
                                <asp:Literal runat="server" ID="ltrStep1"></asp:Literal>

                            </ul>
                            <div class="step-content-wrapper">

                                <asp:Literal runat="server" ID="ltrStep2"></asp:Literal>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section class="our-services-section sec">
            <div class="container">
                <div class="main-title-box">
                    <h2 class="main-title">Dịch vụ của chúng tôi</h2>
                </div>
                <div class="services-wrapper">
                    <asp:Literal runat="server" ID="ltrService"></asp:Literal>

                </div>
            </div>
        </section>
        <div class="customer-benefits-section sec" style="background-image: url(/App_Themes/DangTrang/images/benefits.png);">
            <div class="container">
                <div class="main-title-box">
                    <h2 class="main-title">Quyền lợi khách hàng</h2>
                </div>
                <div class="benefits-section">
                    <div class="columns">
                        <asp:Literal runat="server" ID="ltrQL1"></asp:Literal>

                    </div>
                </div>
                <div class="intro-section">
                    <div class="columns">
                        <div class="column">
                            <div class="intro-item">
                                <p class="intro-counter">2,100</p>
                                <p class="intro-title">Khách hàng</p>
                            </div>
                        </div>
                        <div class="column">
                            <div class="intro-item">
                                <p class="intro-counter">12,000</p>
                                <p class="intro-title">Đơn hàng được đặt</p>
                            </div>
                        </div>
                        <div class="column">
                            <div class="intro-item">
                                <p class="intro-counter">456</p>
                                <p class="intro-title">Phản hồi khách hàng</p>
                            </div>
                        </div>
                        <div class="column">
                            <div class="intro-item">
                                <p class="intro-counter">3456</p>
                                <p class="intro-title">Khách hàng hài lòng</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="contact-section sec">
            <div class="map">
                <%--<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1006548.1603816958!2d105.19853463911258!3d9.780553530874652!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752ed189fa855d%3A0xf63e15bfce46baef!2sC%C3%B4ng%20ty%20TNHH%20-%20MONA%20MEDIA!5e0!3m2!1svi!2s!4v1583310454359!5m2!1svi!2s" frameborder="0" style="border: 0;" allowfullscreen=""></iframe>--%>
                <iframe src="https://www.google.com/maps/embed?pb=!1m16!1m12!1m3!1d10780.896769195628!2d106.76459855278705!3d21.853174345746975!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!2m1!1zMTMxLCBNxKkgU8ahbi4gUCBWxKluaCBUcuG6oWksIFRQIEzhuqFuZyBTxqFu!5e0!3m2!1svi!2s!4v1583896157018!5m2!1svi!2s" width="600" height="450" frameborder="0" style="border:0;" allowfullscreen="" aria-hidden="false" tabindex="0"></iframe>" frameborder="0" style="border: 0;" allowfullscreen=""></iframe>
            
            </div>
            <div class="contact-wrapper">
                <div class="columns">
                    <div class="column">
                        <div class="contact-item">
                            <div class="icon">
                                <i class="fa fa-map-marker" aria-hidden="true"></i>
                            </div>
                            <div class="content">
                                <asp:Literal ID="ltrAddress" runat="server"></asp:Literal>
                            </div>
                        </div>
                    </div>
                    <div class="column">
                        <div class="contact-item">
                            <div class="icon">
                                <i class="fa fa-phone" aria-hidden="true"></i>
                            </div>
                            <div class="content">
                                <p>Hotline:</p>
                                <asp:Literal ID="ltrHotline" runat="server"></asp:Literal>
                            </div>
                        </div>
                    </div>
                    <div class="column">
                        <div class="contact-item">
                            <div class="icon">
                                <i class="fa fa-clock-o" aria-hidden="true"></i>
                            </div>
                            <div class="content">
                                <asp:Literal ID="ltrTimeWork" runat="server"></asp:Literal>
                            </div>
                        </div>
                    </div>
                    <div class="column">
                        <div class="contact-item">
                            <div class="icon">
                                <i class="fa fa-envelope" aria-hidden="true"></i>
                            </div>
                            <div class="content">
                                <p>Email:</p>
                                <asp:Literal ID="ltrEmail" runat="server"></asp:Literal>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </main>
    <asp:HiddenField ID="hdfWebsearch" runat="server" />
    <script type="text/javascript">
        $(document).ready(function () {
            $('.txtSearch').on("keypress", function (e) {
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
        $(document).ready(function () {
            $.ajax({
                type: "POST",
                url: "/Default.aspx/getPopup",
                //data: "{ID:'" + id + "',UserName:'" + username + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    if (msg.d != "null") {
                        var data = JSON.parse(msg.d);
                        var title = data.NotiTitle;
                        var content = data.NotiContent;
                        var email = data.NotiEmail;
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
                        fr += "         <div class=\"content1\">";
                        fr += content;
                        fr += "         </div>";
                        fr += "         <div class=\"content2\">";
                        fr += "<a href=\"javascript:;\" class=\"btn btn-close-full\" onclick='closeandnotshow()'>Đóng & không hiện thông báo</a>";
                        fr += "<a href=\"javascript:;\" class=\"btn btn-close\" onclick='close_popup_ms()'>Đóng</a>";
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
        });

        function searchCode() {
            debugger;
            var code = $("#txtMVD").val();
            if (isEmpty(code)) {
                alert('Vui lòng nhập mã vận đơn.');
            }
            else {
                $.ajax({
                    type: "POST",
                    url: "/theo-doi-mvd.aspx/getInfo",
                    data: "{ordecode:" + code + "}",
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
            background: #29c0e5;
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
            background: #961b4e;
            color: #fff;
            margin: 10px 5px;
            text-transform: none;
            padding: 10px 20px;
        }

            .btn.btn-close:hover {
                background: #752d4b;
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


        @media screen and (max-width: 768px) {
            #popup_content_home {
                left: 10%;
                width: 80%;
            }

            .content1 {
                overflow: auto;
                height: 300px;
            }
        }
    </style>
</asp:Content>



