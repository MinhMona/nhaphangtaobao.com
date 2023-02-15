<%@ Page Language="C#" MasterPageFile="~/TanConDuongToLuaMaster.Master" AutoEventWireup="true" CodeBehind="Default8.aspx.cs" Inherits="NHST.Default5" %>

<asp:Content runat="server" ContentPlaceHolderID="head"></asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <main class="main">
        <div class="home-banner-section sec" style="background-image: url(/App_Themes/conduongtolua/images/home-banner.jpg);">
            <div class="container">
                <div class="home-banner-content wow fadeInLeft">
                    <h2 class="home-banner-sub-title">Welcome to Tan Con Duong To Lua</h2>
                    <h1 class="home-banner-title">Fast and efficient logistics service</h1>
                    <p class="home-banner-desc">Providing flexible, improved service levels, and accelerated delivery. Reduced direct and indirect costs.</p>
                    <div class="home-banner-decor"></div>
                    <div class="home-banner-search">
                        <select name="" id="brand-source" class="f-control select-f-control">
                            <option value="tmall">TMALL</option>
                            <option value="1688">1688</option>
                            <option value="taobao">TAOBAO</option>

                        </select>
                        <asp:TextBox type="text" runat="server" ID="txtSearch" class="f-control input-f-control" placeholder="Tìm kiếm sản phẩm"></asp:TextBox>
                        <a href="javascript:;" onclick="searchProduct()" class="main-btn"><i class="fa fa-search" aria-hidden="true"></i></a>
                        <asp:Button ID="btnSearch" runat="server"
                            OnClick="btnSearch_Click" Style="display: none"
                            OnClientClick="document.forms[0].target = '_blank';" UseSubmitBehavior="false" />
                    </div>
                    <div class="home-banner-btn">
                        <p class="title">Tải công cụ đặt hàng</p>
                        <div class="extensions-btn-wrapper">
                            <a href="https://chrome.google.com/webstore/detail/c%C3%B4ng-c%E1%BB%A5-%C4%91%E1%BA%B7t-h%C3%A0ng-t%C3%A2n-con/nhnkoeedchemlbahfelckepemjichepm" target="_blank" class="main-btn white-btn">
                                <img src="/App_Themes/conduongtolua/images/chrome.png" alt="">Google Chrome</a>
                            <a href="https://chrome.google.com/webstore/detail/c%C3%B4ng-c%E1%BB%A5-%C4%91%E1%BA%B7t-h%C3%A0ng-t%C3%A2n-con/nhnkoeedchemlbahfelckepemjichepm" target="_blank" class="main-btn white-btn">
                                <img src="/App_Themes/conduongtolua/images/coccoc.png" alt="">Cốc Cốc</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="search-section-wrapper" style="background-image: url(/App_Themes/conduongtolua/images/search-section.jpg);">
            <section class="search-section sec">
                <div class="container wow fadeInUp">
                    <div class="main-title-box text-center">
                        <h2 class="main-title">Kiểm tra mã vận đơn</h2>
                        <div class="main-title-decor"></div>
                    </div>
                    <div class="search-form">
                        <input type="text" id="txtMVD" class="f-control" placeholder="Nhập mã vận đơn">
                        <a href="javascript:;" onclick="searchCode()" class="main-btn"><i class="fa fa-search" aria-hidden="true"></i></a>
                    </div>
                </div>
            </section>
            <div class="search-intro-section">
                <div class="container wow fadeInRight">
                    <div class="search-intro-slider main-slider main-slider-stretch">
                        <div class="slide-item">
                            <div class="search-intro-item">
                                <div class="icon">
                                    <img src="/App_Themes/conduongtolua/images/i1.png" alt="">
                                </div>
                                <h4 class="title">Tìm kiếm sản phẩm</h4>
                            </div>
                        </div>
                        <div class="slide-item">
                            <div class="search-intro-item">
                                <div class="icon">
                                    <img src="/App_Themes/conduongtolua/images/i2.png" alt="">
                                </div>
                                <h4 class="title">Tạo đơn hàng</h4>
                            </div>
                        </div>
                        <div class="slide-item">
                            <div class="search-intro-item">
                                <div class="icon">
                                    <img src="/App_Themes/conduongtolua/images/i3.png" alt="">
                                </div>
                                <h4 class="title">Đặt cọc tiền hàng</h4>
                            </div>
                        </div>
                        <div class="slide-item">
                            <div class="search-intro-item">
                                <div class="icon">
                                    <img src="/App_Themes/conduongtolua/images/i4.png" alt="">
                                </div>
                                <h4 class="title">Theo dõi đơn hàng</h4>
                            </div>
                        </div>
                        <div class="slide-item">
                            <div class="search-intro-item">
                                <div class="icon">
                                    <img src="/App_Themes/conduongtolua/images/i5.png" alt="">
                                </div>
                                <h4 class="title">Thanh toán & Nhận hàng</h4>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="intro-section sec" style="background-image: url(/App_Themes/conduongtolua/images/intro-section.jpg);">
            <div class="container wow fadeInLeft">
                <div class="intro-slider-wrapper">
                    <div class="intro-slider main-slider">
                        <div class="slide-item">
                            <div class="intro-item">
                                <div class="intro-icon">
                                    <img src="/App_Themes/conduongtolua/images/i6.png" alt="">
                                </div>
                                <h3 class="intro-title">Order Hàng</h3>
                                <div class="intro-desc">Việc order hàng trên website thương mại giúp tiết kiệm được nhiều công sức, thời gian và những phụ phí phát sinh, đây là giải pháp nhập hàng tối ưu cho chủ kinh doanh và khách mua lẻ.</div>
                            </div>
                        </div>
                        <div class="slide-item">
                            <div class="intro-item">
                                <div class="intro-icon">
                                    <img src="/App_Themes/conduongtolua/images/i7.png" alt="">
                                </div>
                                <h3 class="intro-title">Ký Gửi Hàng</h3>
                                <div class="intro-desc">Qui trình giao nhận của chúng tôi không thể hoàn thiện hơn được nữa bởi sự chính xác của qui trình đóng gói, bảo quản và sự cẩn thận, chuyên nghiệp của đội ngũ nhân viên.</div>
                            </div>
                        </div>
                        <div class="slide-item">
                            <div class="intro-item">
                                <div class="intro-icon">
                                    <img src="/App_Themes/conduongtolua/images/i8.png" alt="">
                                </div>
                                <h3 class="intro-title">Đổi Tiền Alipay</h3>
                                <div class="intro-desc">Đơn giản và nhanh chóng nếu bạn là một người lần đầu mua hàng online trên Website Trung Quốc, bạn có thể sử dụng dịch vụ đặt hàng Trung Quốc trên website Tanconduongtolua.com</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <section class="services-section sec">
            <div class="container wow fadeInUp">
                <div class="main-title-box text-center">
                    <h2 class="main-title">Dịch vụ</h2>
                    <div class="main-title-decor"></div>
                </div>
                <div class="tab-wrapper services-tab-wrapper">
                    <div class="tab-content-wrapper">
                        <asp:Literal runat="server" ID="ltrService2"></asp:Literal>

                    </div>
                    <ul class="tab-link-nav">
                        <asp:Literal runat="server" ID="ltrService1"></asp:Literal>

                    </ul>
                </div>
            </div>
        </section>
        <section class="commitment-section sec" style="background-image: url(/App_Themes/conduongtolua/images/commitment-section.jpg);">
            <div class="container">
                <div class="columns">
                    <div class="column left wow fadeInLeft">
                        <div class="main-title-box">
                            <h2 class="main-title">Cam kết dịch vụ vận chuyển</h2>
                            <div class="main-title-decor"></div>
                        </div>
                    </div>
                    <div class="column right wow fadeInRight">
                        <div class="commitment-wrapper">
                            <div class="columns">
                                <asp:Literal runat="server" ID="ltrCK"></asp:Literal>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section class="faqs-section sec">
            <div class="container">
                <div class="left-img">
                    <img src="/App_Themes/conduongtolua/images/faqs-section.png" alt="">
                </div>
                <div class="right-content wow fadeInRight">
                    <div class="main-title-box">
                        <%-- <p class="sub-title">Chúng tôi đã sẵn sàng để giúp bạn</p>--%>
                        <h2 class="main-title">Quyền lợi khách hàng</h2>
                        <div class="main-title-decor-2"></div>
                    </div>
                    <div class="faqs-wrapper">
                        <asp:Literal runat="server" ID="ltrQL1"></asp:Literal>


                    </div>
                </div>
            </div>
        </section>
        <div class="feedback-support-section-wrapper sec pb-0">
            <div class="container">
                <div class="columns">
                    <div class="column left wow fadeInLeft">
                        <section class="feedback-section">
                            <div class="main-title-box">
                                <h2 class="main-title">Ý kiến khách hàng</h2>
                                <div class="main-title-decor"></div>
                            </div>
                            <div class="feedback-slider-wrapper">
                                <div class="feedback-slider main-slider">
                                    <asp:Literal runat="server" ID="ltrCustomerFeedback"></asp:Literal>

                                </div>
                                <div class="slider-append-wrapper">
                                    <div class="slider-append"></div>
                                </div>
                            </div>
                        </section>
                    </div>
                    <div class="column right wow fadeInRight">
                        <section class="support-section">
                            <div class="main-title-box">
                                <h2 class="main-title">Hỗ trợ khách hàng</h2>
                                <div class="main-title-decor"></div>
                            </div>
                            <ul class="hotline-nav">
                                <asp:Literal runat="server" ID="ltrTeamList"></asp:Literal>

                            </ul>
                        </section>
                    </div>
                </div>
            </div>
        </div>
        <section class="news-section sec" style="background-image: url(/App_Themes/conduongtolua/images/news-section.jpg);">
            <div class="container wow fadeInUp">
                <div class="main-title-box">
                    <h2 class="main-title">Tin mới nhất</h2>
                    <div class="main-title-decor"></div>
                </div>
                <div class="news-slider main-slider main-slider-stretch">
                    <asp:Literal runat="server" ID="Tintuc"></asp:Literal>

                </div>
            </div>
        </section>
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
            background: #9facaf;
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
            background: #dc4d88;
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
                background: #9facaf;
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
