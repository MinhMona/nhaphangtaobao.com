<%@ Page Language="C#" MasterPageFile="~/NhapHangTaoBaoMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NHST.Default6" %>

<asp:Content runat="server" ContentPlaceHolderID="head"></asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <main class="main">
        <div class="banner-sec" style="background-image: url(/App_Themes/NhapHangTaoBao/images/banner.jpg);">
            <div class="container">
                <div class="banner-content">
                    <h1 class="banner-title wow fadeInLeft" style="color: darkcyan">DỊCH VỤ ĐẶT HÀNG TỐT NHẤT</h1>
                    <div class="banner-desc wow fadeInLeft" data-wow-delay=".2s"></div>
                    <div class="banner-btn wow fadeInLeft" data-wow-delay=".4s" style="display: none">
                        <p class="title">Tải công cụ đặt hàng</p>
                        <div class="extensions-btn-wrapper">
                            <a href="https://chrome.google.com/webstore/detail/c%C3%B4ng-c%E1%BB%A5-%C4%91%E1%BA%B7t-h%C3%A0ng-c%E1%BB%A7a-nh%E1%BA%ADp/damcfbhjoblpklhjiclccalmooccakbd" class="main-btn" target="_blank">
                                <img src="/App_Themes/NhapHangTaoBao/images/chrome.png" alt="">GOOGLE CHROME</a>
                            <a href="https://chrome.google.com/webstore/detail/c%C3%B4ng-c%E1%BB%A5-%C4%91%E1%BA%B7t-h%C3%A0ng-c%E1%BB%A7a-nh%E1%BA%ADp/damcfbhjoblpklhjiclccalmooccakbd" class="main-btn" target="_blank">
                                <img src="/App_Themes/NhapHangTaoBao/images/coccoc.png" alt="">CỐC CỐC</a>
                        </div>
                    </div>
                    <div class="banner-btn wow fadeInLeft" data-wow-delay=".4s">
                        <div class="extensions-btn-wrapper">
                            <a href="/">
                                <img src="/App_Themes/NhapHangTaoBao/images/apple.png" alt="" width="28%"></a>
                            <br />
                            <br />
                            <a href="https://play.google.com/store/apps/details?id=com.nhaphangNhaphangtaobao">
                                <img src="/App_Themes/NhapHangTaoBao/images/chplay.png" alt="" width="28%"></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <section class="search-sec sec" style="background-image: url(/App_Themes/NhapHangTaoBao/images/search-tracking-bg.jpg);">
            <div class="container wow zoomIn">
                <div class="tab-wrapper">
                    <div class="main-title-wrap text-center">
                        <h2 class="main-title">
                            <span class="tab-link current" data-tab="#search">TÌM KIẾM HÀNG</span> VÀ <span class="tab-link" data-tab="#tracking">TRACKING</span>
                        </h2>
                        <div class="main-title-decor-2"></div>
                    </div>
                    <div class="tab-content-wrap search-tab-content-wrap">
                        <div class="tab-content" id="search">
                            <div class="search-form">
                                <select id="brand-source" class="f-control select-f-control">
                                    <option value="taobao">Taobao.com</option>
                                    <option value="1688">1688.com</option>
                                    <option value="tmall">Tmall.com</option>
                                </select>
                                <asp:TextBox type="text" runat="server" ID="txtSearch" class="f-control input-f-control" placeholder="Tìm kiếm sản phẩm"></asp:TextBox>
                                <a href="javascript:;" onclick="searchProduct()" class="main-btn"><i class="fa fa-search" aria-hidden="true"></i></a>
                                <asp:Button ID="btnSearch" runat="server"
                                    OnClick="btnSearch_Click" Style="display: none"
                                    OnClientClick="document.forms[0].target = '_blank';" UseSubmitBehavior="false" />
                            </div>
                        </div>
                        <div class="tab-content" id="tracking">
                            <div class="search-form">
                                <input type="text" id="txtMVD" class="f-control" placeholder="Nhập mã vận đơn">
                                <a href="javascript:;" onclick="searchCode()" class="main-btn"><i class="fa fa-search" aria-hidden="true"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <div class="intro-sec sec">
            <div class="container wow fadeInLeft">
                <div class="intro-wrap">
                    <asp:Literal runat="server" ID="ltrCK"></asp:Literal>

                </div>
            </div>
        </div>
        <div class="step-sec sec pt-0">
            <div class="container wow fadeInRight">
                <div class="main-title-wrap">
                    <h2 class="main-title" style="text-align: center">QUY TRÌNH ĐẶT HÀNG</h2>
                </div>
                <div class="step-wrap">
                    <div class="columns">
                        <div class="column">
                            <div class="step-img">
                                <img src="/App_Themes/NhapHangTaoBao/images/step.jpg" alt="">
                            </div>
                        </div>
                        <div class="column">
                            <div class="faqs-wrap">
                                <asp:Literal runat="server" ID="ltrQuyTrinh"></asp:Literal>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="counter-sec sec">
            <div class="container wow fadeIn">
                <div class="columns">
                    <div class="column">
                        <div class="counter-item">
                            <div class="counter-icon">
                                <img src="/App_Themes/NhapHangTaoBao/images/counter-1.png" alt="">
                            </div>
                            <h3 class="counter-title">103,300</h3>
                            <div class="counter-desc">Tổng đơn hàng</div>
                        </div>
                    </div>
                    <div class="column">
                        <div class="counter-item">
                            <div class="counter-icon">
                                <img src="/App_Themes/NhapHangTaoBao/images/counter-2.png" alt="">
                            </div>
                            <h3 class="counter-title">12.530</h3>
                            <div class="counter-desc">Tổng khách hàng</div>
                        </div>
                    </div>
                    <div class="column">
                        <div class="counter-item">
                            <div class="counter-icon">
                                <img src="/App_Themes/NhapHangTaoBao/images/counter-3.png" alt="">
                            </div>
                            <h3 class="counter-title">10</h3>
                            <div class="counter-desc">Số năm hoạt động</div>
                        </div>
                    </div>
                    <div class="column">
                        <div class="counter-item">
                            <div class="counter-icon">
                                <img src="/App_Themes/NhapHangTaoBao/images/counter-4.png" alt="">
                            </div>
                            <h3 class="counter-title">53</h3>
                            <div class="counter-desc">Số nhân viên</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <section class="tariff-sec sec">
            <div class="container wow fadeInLeft">
                <div class="main-title-wrap text-center">
                    <h2 class="main-title">BIỂU PHÍ</h2>

                </div>
                <div class="tariff-wrap">
                    <div class="columns">
                        <div class="column tariff-left">
                            <div class="tariff-img">
                                <img src="/App_Themes/NhapHangTaoBao/images/tariff.png" alt="">
                            </div>
                        </div>
                        <div class="column tariff-right">
                            <ul class="tariff-nav">
                                <li>
                                    <img src="/App_Themes/NhapHangTaoBao/images/tariff-1.png" alt="">Phí mua hàng</li>
                                <li>
                                    <img src="/App_Themes/NhapHangTaoBao/images/tariff-2.png" alt="">Phí vận chuyển</li>
                                <li>
                                    <img src="/App_Themes/NhapHangTaoBao/images/tariff-3.png" alt="">Thời gian vận chuyển nhanh nhất, chỉ từ 4-6 ngày</li>
                                <li>
                                    <img src="/App_Themes/NhapHangTaoBao/images/tariff-4.png" alt="">Công thức quy đổi khổi / cân nặng</li>
                                <li>
                                    <img src="/App_Themes/NhapHangTaoBao/images/tariff-5.png" alt="">Công thức ước tính giá trị đơn hàng</li>
                            </ul>
                            <a href="/chuyen-muc/bang-gia" class="main-btn">CHI TIẾT</a>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section class="plan-sec sec pt-0">
            <div class="container wow fadeInRight">
                <div class="main-title-wrap text-center">
                    <h2 class="main-title">KHÁCH HÀNG THÂN THIẾT</h2>

                </div>
                <div class="plan-wrap">
                    <div class="columns">
                        <div class="column">
                            <div class="plan-item">
                                <h3 class="plan-title">VIP 6</h3>
                                <p class="plan-price">5B - 10B</p>
                                <ul class="plan-desc">
                                    <li>Chiết khấu cân nặng: 6%</li>
                                    <li>Chiết khấu phí mua hàng: 30%</li>
                                    <li>Đặt cọc: 55%</li>
                                    <li>Quà sinh nhật</li>
                                    <li></li>
                                </ul>
                            </div>
                        </div>
                        <div class="column">
                            <div class="plan-item">
                                <h3 class="plan-title">VIP 7</h3>
                                <p class="plan-price">10B - 20B</p>
                                <ul class="plan-desc">
                                    <li>Chiết khấu cân nặng: 8%</li>
                                    <li>Chiết khấu phí mua hàng: 35%</li>
                                    <li>Đặt cọc: 50%</li>
                                    <li>Quà sinh nhật</li>
                                    <li>Hỗ trợ ship nội thành Hà Nội</li>
                                </ul>
                            </div>
                        </div>
                        <div class="column">
                            <div class="plan-item">
                                <h3 class="plan-title">VIP 8</h3>
                                <p class="plan-price">Trên 20B</p>
                                <ul class="plan-desc">
                                    <li>Chiết khấu cân nặng: 10%</li>
                                    <li>Chiết khấu phí mua hàng: 30%</li>
                                    <li>Đặt cọc: 45%</li>
                                    <li>Quà sinh nhật</li>
                                    <li>Hỗ trợ ship nội thành Hà Nội</li>
                                </ul>
                            </div>
                        </div>
                    </div>
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
                        fr += "         <div class=\"content1 over-flow-auto\">";
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
            var code = $("#txtMVD").val();
            if (isEmpty(code)) {
                alert('Vui lòng nhập mã vận đơn.');
            }
            else {
                $.ajax({
                    type: "POST",
                    url: "/Default.aspx/getInfo",
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
            background-color: #DC3545;
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
            background: #DC3545;
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

        .date-time.tq:before {
            content: 'Ngày về kho TQ:';
            font-weight: bold;
            padding-right: 9px;
        }

        .date-time.tq {
            display: flex;
        }

        .date-time.vn:before {
            content: 'Ngày về kho VN:';
            font-weight: bold;
            padding-right: 9px;
        }

        .date-time.vn {
            display: flex;
        }

        .date-time.ht:before {
            content: 'Ngày hoàn thành:';
            font-weight: bold;
            padding-right: 9px;
        }

        .date-time.ht {
            display: flex;
        }

        .grey89.font-w {
            font-weight: bold;
        }

        .over-flow-auto {
            overflow: auto;
            height: 350px;
        }
        /* Let's get this party started */
        ::-webkit-scrollbar {
            width: 12px;
        }

        /* Track */
        ::-webkit-scrollbar-track {
            -webkit-box-shadow: inset 0 0 6px rgba(0,0,0,0.3);
            -webkit-border-radius: 10px;
            border-radius: 10px;
        }

        /* Handle */
        ::-webkit-scrollbar-thumb {
            -webkit-border-radius: 10px;
            border-radius: 10px;
            background: rgba(255,0,0,0.8);
            -webkit-box-shadow: inset 0 0 6px rgba(0,0,0,0.5);
        }

            ::-webkit-scrollbar-thumb:window-inactive {
                background: rgba(255,0,0,0.4);
            }
    </style>
</asp:Content>
