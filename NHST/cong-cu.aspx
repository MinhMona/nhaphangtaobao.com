<%@ Page Title="" Language="C#" MasterPageFile="~/NhapHangTaoBaoMaster.Master" AutoEventWireup="true" CodeBehind="cong-cu.aspx.cs" Inherits="NHST.cong_cu1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .services {
            background: #f8f8f8;
        }

        .breadcrumb {
            background-color: #ccc;
            padding: 22px 0 15px;
            font-size: 12px;
            text-transform: uppercase;
            font-weight: 500;
            list-style-type: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="main" style="padding-bottom:10px">
        <div class="breadcrumb wow fadeIn" data-wow-duration="1s" data-wow-delay="0s">
            <div class="container">
                <ul>
                    <li><a href="/">Trang chủ</a></li>
                    <li><a href="/cong-cu">Công Cụ Đặt Hàng</a></li>
                </ul>
            </div>
        </div>
        <div class="sec-tt">
            <h2 class="tt-txt" style="text-align: center">ĐẶT HÀNG BẰNG TIỆN ÍCH CHROME</h2>
            <p class="deco" style="text-align:center"><img src="/App_Themes/NhapHangTaoBao/images/title-deco.png" alt=""></p>
        </div>
        <div class="order-tool clearfix">
            <div class="order-tool-left">
                <img src="/App_Themes/NhapHangTaoBao/images/congcu-img.png" alt="">
            </div>
            <div class="order-tool-right">
                <h3 class="order-title">ADDON Nhập hàng TAOBAO SẼ GIÚP BẠN:</h3>
                <p>1. Tiết kiệm thời gian và tăng cơ hội kinh doanh</p>
                <p>2. Đặt hàng nhanh chóng, thuận tiện và chính xác</p>
                <p>3. Form đặt hàng hiển thị sẵn khi vào trang chi tiết</p>
                <p>4. Hỗ trợ dịch tự động từ tiếng Trung sang tiếng Việt</p>
                <h3 class="order-title">SỬ DỤNG TRÊN TRÌNH DUYỆT CHROME & CỜ RÔM+ (CỐC CỐC)</h3>
                <p>
                    Cài đặt nhanh chóng, hạn chế tối đa việc cài đặt lại
							Tự động cập nhật khi có phiên bản mới
                </p>
                <p>
                    <a target="_blank" href="https://chrome.google.com/webstore/detail/c%C3%B4ng-c%E1%BB%A5-%C4%91%E1%BA%B7t-h%C3%A0ng-c%E1%BB%A7a-nh%E1%BA%ADp/damcfbhjoblpklhjiclccalmooccakbd">Click để cài đặt</a>
                </p>
                <div class="tool-setting">
                    <a target="_blank" href="https://chrome.google.com/webstore/detail/c%C3%B4ng-c%E1%BB%A5-%C4%91%E1%BA%B7t-h%C3%A0ng-c%E1%BB%A7a-nh%E1%BA%ADp/damcfbhjoblpklhjiclccalmooccakbd"
                        class="btn primary-btn pill-btn"><i class="fa fa-chrome"></i>CHROME</a>

                    <a target="_blank" href="https://chrome.google.com/webstore/detail/c%C3%B4ng-c%E1%BB%A5-%C4%91%E1%BA%B7t-h%C3%A0ng-c%E1%BB%A7a-nh%E1%BA%ADp/damcfbhjoblpklhjiclccalmooccakbd"
                        class="btn primary-btn pill-btn"><i class="fa fa-chrome"></i>CỐC CỐC</a>

                </div>
            </div>
            <div class="clearfix"></div>

        </div>


    </main>
    <style>
        .order-tool-left {
            width: 50%;
            float: left;
        }

            .order-tool-left img {
                width: 77%;
                /*min-height: 342px;*/
                float: right
            }

        .order-tool-right {
            width: 50%;
            float: right;
            padding-left: 50px;
        }

        .order-title {
            font-size: 15px;
            color: #404040;
            text-transform: uppercase;
            font-weight: 700;
            margin: 7px 0;
        }

        .order-tool-right p {
            font-size: 15px;
            color: #404040;
            margin: 10px 0;
            width: 80%;
        }

            .order-tool-right p a {
                color: #d92027;
                font-weight: 700;
            }

        /*.tool-setting {
            margin-top: 40px;
        }*/

            .tool-setting a {
                float: left;
                padding-right: 20px;
            }

        .tool-detail {
            text-align: center;
            clear: both;
        }

            .tool-detail p {
                color: #3e3c3c;
                font-size: 15px;
                padding: 10px 0;
                line-height: 24px;
                text-align: left;
            }

                .tool-detail p span {
                    text-transform: uppercase;
                }

        .tool-detail-title {
            color: #d92027;
            text-transform: uppercase;
            font-size: 15px;
            font-weight: 700;
            text-align: left;
        }

        .cmt {
            margin-top: 30px;
            width: 100%;
            float: left;
            text-align: left;
        }

            .cmt img {
                width: 100%;
            }

        .btn {
            display: inline-block;
        }

            .btn.pill-btn {
                padding: 0 25px;
                font-weight: bold;
                border: solid 1px;
                border-radius: 20px;
            }

            .btn.primary-btn {
                background-color: #e84545;
                color: white;
                height:30px;
                line-height:30px;
            }
    </style>
</asp:Content>
