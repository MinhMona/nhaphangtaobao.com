using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using NHST.Bussiness;
using NHST.Controllers;
using Supremes;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI.HtmlControls;

namespace NHST
{
    public partial class giaothuong24hMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //LoadMenu();
                LoadData();
            }
        }
        public void LoadMenu()
        {
            string dichvu = "";
            string banggia = "";
            string huongdan = "";
            string chinhsach = "";
            string tuyendung = "";
            string gioithieu = "";
            var pagetype = PageTypeController.GetAll();
            if (pagetype.Count > 0)
            {
                foreach (var t in pagetype)
                {
                    if (t.ID == 1)
                    {
                        var pages = PageController.GetByPagetTypeID(t.ID);
                        if (pages.Count > 0)
                        {
                            banggia += "<li class=\"has-dropdown nav-item baogia\">";
                            banggia += "    <a href=\"" + t.NodeAliasPath + "\" role=\"item__btn\">" + t.PageTypeName + "</a>";
                            banggia += "    <ul class=\"mn-dropdown-menu\">";
                            foreach (var p in pages)
                            {
                                banggia += "        <li class=\"\"><a href=\"" + p.NodeAliasPath + "\">" + p.Title + "</a></li>";
                            }
                            banggia += "    </ul>";
                            banggia += "</li>";
                        }
                        else
                        {
                            banggia += "<li class=\"nav-item baogia\">";
                            banggia += "    <a class=\"nav-item__name\"  href=\"" + t.NodeAliasPath + "\" role=\"item__btn\">" + t.PageTypeName + "</a>";
                            banggia += "</li>";
                        }
                    }
                    else if (t.ID == 3)
                    {
                        var pages = PageController.GetByPagetTypeID(t.ID);
                        if (pages.Count > 0)
                        {
                            huongdan += "<li class=\"has-dropdown nav-item huongdan\">";
                            huongdan += "    <a href=\"" + t.NodeAliasPath + "\" role=\"item__btn\">" + t.PageTypeName + "</a>";
                            huongdan += "    <ul class=\"mn-dropdown-menu\">";
                            foreach (var p in pages)
                            {
                                huongdan += "        <li class=\"\"><a href=\"" + p.NodeAliasPath + "\">" + p.Title + "</a></li>";
                            }
                            huongdan += "    </ul>";
                            huongdan += "</li>";
                        }
                        else
                        {
                            huongdan += "<li class=\"nav-item huongdan\">";
                            huongdan += "    <a class=\"nav-item__name\"  href=\"" + t.NodeAliasPath + "\" role=\"item__btn\">" + t.PageTypeName + "</a>";
                            huongdan += "</li>";
                        }
                    }
                    else if (t.ID == 6)
                    {
                        var pages = PageController.GetByPagetTypeID(t.ID);
                        if (pages.Count > 0)
                        {
                            dichvu += "<li class=\"has-dropdown nav-item dichvu\">";
                            dichvu += "    <a href=\"" + t.NodeAliasPath + "\" role=\"item__btn\">" + t.PageTypeName + "</a>";
                            dichvu += "    <ul class=\"mn-dropdown-menu\">";
                            foreach (var p in pages)
                            {
                                dichvu += "        <li class=\"\"><a href=\"" + p.NodeAliasPath + "\">" + p.Title + "</a></li>";
                            }
                            dichvu += "    </ul>";
                            dichvu += "</li>";
                        }
                        else
                        {
                            dichvu += "<li class=\"nav-item dichvu\">";
                            dichvu += "    <a class=\"nav-item__name\"  href=\"" + t.NodeAliasPath + "\" role=\"item__btn\">" + t.PageTypeName + "</a>";
                            dichvu += "</li>";
                        }
                    }
                    else if (t.ID == 7)
                    {
                        var pages = PageController.GetByPagetTypeID(t.ID);
                        if (pages.Count > 0)
                        {
                            gioithieu += "<li class=\"has-dropdown nav-item gioithieu\">";
                            gioithieu += "    <a href=\"" + t.NodeAliasPath + "\" role=\"item__btn\">" + t.PageTypeName + "</a>";
                            gioithieu += "    <ul class=\"mn-dropdown-menu\">";
                            foreach (var p in pages)
                            {
                                gioithieu += "        <li class=\"\"><a href=\"" + p.NodeAliasPath + "\">" + p.Title + "</a></li>";
                            }
                            gioithieu += "    </ul>";
                            gioithieu += "</li>";
                        }
                        else
                        {
                            gioithieu += "<li class=\"nav-item gioithieu\">";
                            gioithieu += "    <a class=\"nav-item__name\"  href=\"" + t.NodeAliasPath + "\" role=\"item__btn\">" + t.PageTypeName + "</a>";
                            gioithieu += "</li>";
                        }
                    }
                    else if (t.ID == 10)
                    {
                        var pages = PageController.GetByPagetTypeID(t.ID);
                        if (pages.Count > 0)
                        {
                            chinhsach += "<li class=\"has-dropdown nav-item chinhsach\">";
                            chinhsach += "    <a href=\"" + t.NodeAliasPath + "\" role=\"item__btn\">" + t.PageTypeName + "</a>";
                            chinhsach += "    <ul class=\"mn-dropdown-menu\">";
                            foreach (var p in pages)
                            {
                                chinhsach += "        <li class=\"\"><a href=\"" + p.NodeAliasPath + "\">" + p.Title + "</a></li>";
                            }
                            chinhsach += "    </ul>";
                            chinhsach += "</li>";
                        }
                        else
                        {
                            chinhsach += "<li class=\"nav-item chinhsach\">";
                            chinhsach += "    <a class=\"nav-item__name\"  href=\"" + t.NodeAliasPath + "\" role=\"item__btn\">" + t.PageTypeName + "</a>";
                            chinhsach += "</li>";
                        }
                    }
                    else if (t.ID == 14)
                    {
                        var pages = PageController.GetByPagetTypeID(t.ID);
                        if (pages.Count > 0)
                        {
                            tuyendung += "<li class=\"has-dropdown nav-item tuyendung\">";
                            tuyendung += "    <a href=\"" + t.NodeAliasPath + "\" role=\"item__btn\">" + t.PageTypeName + "</a>";
                            tuyendung += "    <ul class=\"mn-dropdown-menu\">";
                            foreach (var p in pages)
                            {
                                tuyendung += "        <li class=\"\"><a href=\"" + p.NodeAliasPath + "\">" + p.Title + "</a></li>";
                            }
                            tuyendung += "    </ul>";
                            tuyendung += "</li>";
                        }
                        else
                        {
                            tuyendung += "<li class=\"nav-item tuyendung\">";
                            tuyendung += "    <a class=\"nav-item__name\"  href=\"" + t.NodeAliasPath + "\" role=\"item__btn\">" + t.PageTypeName + "</a>";
                            tuyendung += "</li>";
                        }
                    }
                }
            }
            //ltrdichvu.Text = dichvu;
            //ltrbanggia.Text = banggia;
            //ltrhuongdan.Text = huongdan;
            //ltrchinhsach.Text = chinhsach;
            //ltrtuyendung.Text = tuyendung;
            //ltrgioithieu.Text = gioithieu;
        }
        public void LoadData()
        {
            var confi = ConfigurationController.GetByTop1();
            if (confi != null)
            {
                #region lấy meta
                HtmlHead objHeader = (HtmlHead)Page.Header;
                HtmlMeta meta = new HtmlMeta();
                meta = new HtmlMeta();
                meta.Attributes.Add("name", "description");
                meta.Content = confi.MetaDescription;
                objHeader.Controls.Add(meta);

                meta = new HtmlMeta();
                meta.Attributes.Add("name", "keyword");
                meta.Content = confi.MetaKeyword;
                objHeader.Controls.Add(meta);
                ltrSEO.Text += "<script>" + confi.GoogleAnalytics + "</script>";
                ltrSEO.Text += "<script>" + confi.WebmasterTools + "</script>";
                #endregion

                string email = confi.EmailSupport;
                string hotline = confi.Hotline;
                string timework = confi.TimeWork;
                ltrFooter.Text = confi.FooterLeft;

                //ltrAboutUs.Text = confi.AboutText;
                ltrHotlineCall.Text += "<a href=\"tel:" + hotline + "\" class=\"fancybox\">";
                ltrHotlineCall.Text += "<div class=\"coccoc-alo-phone coccoc-alo-green coccoc-alo-show\" id=\"coccoc-alo-phoneIcon\">";
                ltrHotlineCall.Text += "<div class=\"coccoc-alo-ph-circle\"></div>";
                ltrHotlineCall.Text += "<div class=\"coccoc-alo-ph-circle-fill\"></div>";
                ltrHotlineCall.Text += "<div class=\"coccoc-alo-ph-img-circle\"></div>";
                ltrHotlineCall.Text += "</div>";
                ltrHotlineCall.Text += "</a>";

                ltrTop.Text += "<div class=\"hdt__info-block\" style=\"padding: 7px 10px;\">";
                ltrTop.Text += "	<div class=\"img\"><img src=\"/App_Themes/giaothuong24h/images/hd-top-icon1.png\" alt=\"\"></div>";
                ltrTop.Text += "	<div class=\"ct\">Tỉ giá tiền: 1¥ = " + string.Format("{0:N0}", Convert.ToDouble(confi.Currency)) + " vnđ</div>";
                ltrTop.Text += "</div>";
                ltrTop.Text += "<div class=\"hdt__info-block\">";
                ltrTop.Text += "	<div class=\"img\"><img src=\"/App_Themes/giaothuong24h/images/hd-top-icon2.png\" alt=\"\"></div>";
                ltrTop.Text += "	<div class=\"ct\"><p class=\"tt\">" + confi.Address + "</p></div>";
                ltrTop.Text += "</div>";
                ltrTop.Text += "<div class=\"hdt__info-block\">";
                ltrTop.Text += "	<div class=\"img\"><img src=\"/App_Themes/giaothuong24h/images/hd-top-icon3.png\" alt=\"\"></div>";
                ltrTop.Text += "	<div class=\"ct\">" + timework + "</div>";
                ltrTop.Text += "</div>";
                ltrLogo.Text = "  <img src=\"" + confi.LogoIMG + "\" alt=\"\">";
                //ltrTopLeft.Text += "<li>Tỷ giá: 1¥ = <span>" + string.Format("{0:N0}", Convert.ToDouble(confi.Currency)) + "</span></li>";
                //ltrTopLeft.Text += "<li>" + timework + "</li>";
                //ltrTopLeft.Text += "<li>Tel: <a href=\"tel:" + hotline + "\">" + hotline + "</a></li>";

                //ltrFooterInfo.Text += "<li><span class=\"title\">Địa chỉ</span><p>" + confi.Address + "</p></li>";
                //ltrFooterInfo.Text += "<li><span class=\"title\">Hotline</span><p><a href=\"tel:" + hotline + "\">" + hotline + "</a></p></li>";
                //ltrFooterInfo.Text += "<li><span class=\"title\">Email contact</span><p><a href=\"mailto:" + email + "\">" + email + "</a></p></li>";

                //ltrSocial.Text += "<li><a href=\"" + confi.Facebook + "\"><i class=\"fab fa-facebook-f\"></i></a></li>";
                //ltrSocial.Text += "<li><a href=\"" + confi.GooglePlus + "\"><i class=\"fab fa-google-plus-g\"></i></a></li>";
                //ltrSocial.Text += "<li><a href=\"" + confi.YoutubeLink + "\"><i class=\"fab fa-youtube\"></i></a></li>";

                string infocontent = confi.InfoContent;
                if (Session["infoclose"] == null)
                {
                    if (!string.IsNullOrEmpty(infocontent))
                    {
                        ltr_infor.Text += "<div class=\"sec webinfo\">";
                        ltr_infor.Text += "<div class=\"all-info\">";
                        ltr_infor.Text += "<div class=\"main-info\">";
                        ltr_infor.Text += "<div class=\"textcontent\">";
                        ltr_infor.Text += "<span>" + infocontent + "</span>";
                        ltr_infor.Text += "<a href=\"javascript:;\" onclick=\"closewebinfo()\" class=\"icon-close-info\"><i class=\"fa fa-times\"></i></a>";
                        ltr_infor.Text += "</div></div></div></div>";
                    }
                }
            }
            if (Session["userLoginSystem"] != null)
            {
                string username = Session["userLoginSystem"].ToString();
                var acc = AccountController.GetByUsername(username);
                if (acc != null)
                {
                    var ordershoptemp = OrderShopTempController.GetByUID(acc.ID);
                    int count = 0;
                    if (ordershoptemp.Count > 0)
                        count = ordershoptemp.Count;
                    #region phần thông báo
                    decimal levelID = Convert.ToDecimal(acc.LevelID);
                    int levelID1 = Convert.ToInt32(acc.LevelID);
                    string level = "1 Vương Miện";
                    var userLevel = UserLevelController.GetByID(levelID1);
                    if (userLevel != null)
                    {
                        level = userLevel.LevelName;
                    }
                    string userIMG = "/App_Themes/CIQOrder/images/user-icon.png";
                    var ai = AccountInfoController.GetByUserID(acc.ID);
                    if (ai != null)
                    {
                        if (!string.IsNullOrEmpty(ai.IMGUser))
                            userIMG = ai.IMGUser;
                    }

                    decimal countLevel = UserLevelController.GetAll("").Count();
                    decimal te = levelID / countLevel;
                    te = Math.Round(te, 2, MidpointRounding.AwayFromZero);
                    decimal tile = te * 100;
                    string levelIconList = "";
                    string levelIconSingle = "";
                    var userLevels = UserLevelController.GetAll("");
                    if (userLevels.Count > 0)
                    {
                        foreach (var item in userLevels)
                        {
                            if (item.ID <= levelID)
                            {
                                levelIconList += "<img style=\"margin-right:5px;width:15%\" src=\"/App_Themes/StarExpress/images/vm-active.png\">";
                                //levelIconSingle += "<img src=\"/App_Themes/CIQOrder/images/vm-active.png\">";
                            }
                            else
                            {
                                levelIconList += "<img style=\"margin-right:5px;width:15%\" src=\"/App_Themes/StarExpress/images/vm-inactive.png\">";
                            }
                        }
                    }
                    var notis = NotificationsController.GetAll(acc.ID);
                    #region Lấy thông tin mới
                    //ltrLogin.Text += "<div class=\"main-top-child account\">";
                    //ltrLogin.Text += "      <div class=\"acc-info\">";
                    //ltrLogin.Text += "          <a href=\"/thong-tin-nguoi-dung\" class=\"hl\">Xin chào: " + acc.Username + "</a>";
                    //ltrLogin.Text += "          <div class=\"status\">";
                    //ltrLogin.Text += "              <div class=\"status-wrap\">";
                    //ltrLogin.Text += "                  <div class=\"status__header\">";
                    //ltrLogin.Text += "                      <h4 style=\"font-size:16px;\">" + acc.Username + "</h4>";
                    //ltrLogin.Text += "                  </div>";
                    //ltrLogin.Text += "                  <div class=\"status__body\">";
                    //ltrLogin.Text += "                      <div class=\"level\">";
                    //ltrLogin.Text += "                          <div class=\"level__process\" style=\"background:none;height:auto;text-align:center\">";
                    //ltrLogin.Text += levelIconList;
                    //ltrLogin.Text += "                          </div>";
                    //ltrLogin.Text += "                          <div class=\"level__process\">";
                    //ltrLogin.Text += "                              <span style=\"width: " + tile + "%\"></span>";
                    //ltrLogin.Text += "                          </div>";
                    //ltrLogin.Text += "                      </div>";
                    //ltrLogin.Text += "                      <div class=\"balance\">";
                    //ltrLogin.Text += "                          <p>Số dư:</p>";
                    //ltrLogin.Text += "                          <div class=\"balance__number\">";
                    //ltrLogin.Text += "                              <p class=\"vnd\">" + string.Format("{0:N0}", acc.Wallet) + " vnđ</p>";
                    //ltrLogin.Text += "                          </div>";
                    //ltrLogin.Text += "                      </div>";
                    //if (acc.RoleID != 1)
                    //{
                    //    ltrLogin.Text += "                  <div class=\"links\">";
                    //    ltrLogin.Text += "                      <a href=\"/manager/login\">Quản trị<i class=\"fa fa-caret-right\"></i></a>";
                    //    ltrLogin.Text += "                  </div>";
                    //}
                    //ltrLogin.Text += "                      <div class=\"links\">";
                    //ltrLogin.Text += "                          <a href=\"/thong-tin-nguoi-dung\">Thông tin tài khoản<i class=\"fa fa-caret-right\"></i></a>";
                    //ltrLogin.Text += "                      </div>";
                    //ltrLogin.Text += "                      <div class=\"links\">";
                    //ltrLogin.Text += "                          <a href=\"/danh-sach-don-hang?t=1\">Đơn hàng của bạn<i class=\"fa fa-caret-right\"></i></a>";
                    //ltrLogin.Text += "                      </div>";
                    //ltrLogin.Text += "                      <div class=\"links\">";
                    //ltrLogin.Text += "                          <a href=\"/lich-su-giao-dich\">Lịch sử giao dịch<i class=\"fa fa-caret-right\"></i></a>";
                    //ltrLogin.Text += "                      </div>";
                    //ltrLogin.Text += "                  </div>";
                    //ltrLogin.Text += "                  <div class=\"status__footer\">";
                    //ltrLogin.Text += "                      <a href=\"/dang-xuat\" class=\"ft-btn\">ĐĂNG XUẤT</a>";
                    //ltrLogin.Text += "                  </div>";
                    //ltrLogin.Text += "              </div>";
                    //ltrLogin.Text += "          </div>";
                    //ltrLogin.Text += "      </div>";
                    //ltrLogin.Text += "</div>";

                    #endregion
                    #endregion
                    #region Lấy thông tin user mới
                    //ltrTopRight.Text += "<div class=\"item-info-hd\">";
                    //ltrTopRight.Text += "<div class=\"acc-info\">";
                    //ltrTopRight.Text += "<a class=\"hl\"><span class=\"icon\"><i class=\"fa fa-user\" aria-hidden=\"true\"></i></span><span class=\"hidden-mobile\">" + username + "</span></a>";
                    //ltrTopRight.Text += "<div class=\"status\">";
                    //ltrTopRight.Text += "<div class=\"status-wrap\">";
                    //ltrTopRight.Text += "<div class=\"status__header\">";
                    //ltrTopRight.Text += "<h4>" + level + "</h4>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "<div class=\"status__body\">";
                    //ltrTopRight.Text += "<div class=\"level\">";
                    //ltrTopRight.Text += "<div class=\"level__process\" style=\"background:none;height:auto;text-align:center\">";
                    //ltrTopRight.Text += levelIconList;
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "<div class=\"level__process\">";
                    //ltrTopRight.Text += "<span style=\"width: " + tile + "%\"></span>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "<div class=\"balance\">";
                    //ltrTopRight.Text += "<p>Số dư:</p>";
                    //ltrTopRight.Text += "<div class=\"balance__number\">";
                    //ltrTopRight.Text += "<p class=\"vnd\">" + string.Format("{0:N0}", acc.Wallet) + " vnđ</p>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "</div>";
                    //if (acc.RoleID != 1)
                    //{
                    //    ltrTopRight.Text += "<div class=\"links\">";
                    //    ltrTopRight.Text += "   <a href=\"/manager/login\">Quản trị<i class=\"fa fa-caret-right\"></i></a>";
                    //    ltrTopRight.Text += "</div>";
                    //}
                    //ltrTopRight.Text += "   <div class=\"links\">";
                    //ltrTopRight.Text += "       <a href=\"/thong-tin-nguoi-dung\">Thông tin tài khoản<i class=\"fa fa-caret-right\"></i></a>";
                    //ltrTopRight.Text += "   </div>";
                    //ltrTopRight.Text += "   <div class=\"links\">";
                    //ltrTopRight.Text += "       <a href=\"/danh-sach-don-hang?t=1\">Đơn hàng của bạn<i class=\"fa fa-caret-right\"></i></a>";
                    //ltrTopRight.Text += "   </div>";
                    //ltrTopRight.Text += "   <div class=\"links\">";
                    //ltrTopRight.Text += "       <a href=\"/lich-su-giao-dich\">Lịch sử giao dịch<i class=\"fa fa-caret-right\"></i></a>";
                    //ltrTopRight.Text += "   </div>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "<div class=\"status__footer\">";
                    //ltrTopRight.Text += "<a href=\"/dang-xuat\" class=\"ft-btn\">ĐĂNG XUẤT</a>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "<div class=\"menu-profile\">";
                    //ltrTopRight.Text += "<div class=\"nav-overlay\"></div>";
                    //ltrTopRight.Text += "<div class=\"profile-content\">";
                    //ltrTopRight.Text += "<div class=\"profile-top\">";
                    //ltrTopRight.Text += "<div class=\"avatar\">";
                    //ltrTopRight.Text += "<a href=\"/thong-tin-nguoi-dung\"><img src=\"" + userIMG + "\"></a>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "<div class=\"info-user-top\">";
                    //ltrTopRight.Text += "<a class=\"user_name\" href=\"/thong-tin-nguoi-dung\">" + username + "</a>";
                    //ltrTopRight.Text += "<div class=\"info-user\">";
                    //ltrTopRight.Text += "<a href=\"#\">";
                    //ltrTopRight.Text += "<span class=\"name\">Số tiền: </span>";
                    //ltrTopRight.Text += "<span class=\"value\">" + string.Format("{0:N0}", acc.Wallet) + " vnđ</span>";
                    //ltrTopRight.Text += "<span class=\"name\"> | Level: <span class=\"value color_orther\">" + level + "</span></span>";
                    //ltrTopRight.Text += "</a>";
                    //ltrTopRight.Text += "<div class=\"nav-percent\">";
                    //ltrTopRight.Text += "<div class=\"nav-percent-ok\" style=\"width: " + tile + "%\"></div>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "<div class=\"profile-bottom\">";
                    //ltrTopRight.Text += "<ul class=\"menu-in-profile\">";
                    //ltrTopRight.Text += "<li>";
                    //ltrTopRight.Text += "<a href=\"/\"><i class=\"fa fa-home\" aria-hidden=\"true\"></i>TRANG CHỦ</a>";
                    //ltrTopRight.Text += "</li>";
                    //ltrTopRight.Text += "<li>";
                    //ltrTopRight.Text += "<a href=\"/theo-doi-mvd\"><i class=\"fa fa-search\" aria-hidden=\"true\"></i>TRACKING</a>";
                    //ltrTopRight.Text += "</li>";
                    //ltrTopRight.Text += "<li class=\"has-submenu\">";
                    //ltrTopRight.Text += "<a href=\"/danh-sach-don-hang?t=1\"><i class=\"fa fa-home\" aria-hidden=\"true\"></i>MUA HÀNG HỘ  <span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    //ltrTopRight.Text += "<ul class=\"sub-menu\">";
                    //ltrTopRight.Text += "<li>";
                    //ltrTopRight.Text += "<a href=\"/tao-don-hang-khac\">Đặt hàng ngoài hệ thống</a>";
                    //ltrTopRight.Text += "</li>";
                    //ltrTopRight.Text += "<li>";
                    //ltrTopRight.Text += "<a href=\"/danh-sach-don-hang?t=1\">Đơn hàng</a>";
                    //ltrTopRight.Text += "</li>";
                    //ltrTopRight.Text += "<li><a href=\"/danh-sach-don-hang?t=3\">Đơn hàng thương mại điện tử khác</a></li>";
                    //ltrTopRight.Text += "</ul>";
                    //ltrTopRight.Text += "</li>";
                    //ltrTopRight.Text += "<li class=\"has-submenu\">";
                    //ltrTopRight.Text += "<a href=\"/danh-sach-don-van-chuyen-ho\"><i class=\"fa fa-truck\" aria-hidden=\"true\"></i>VẬN CHUYỂN HỘ<span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    //ltrTopRight.Text += "</li>";
                    //ltrTopRight.Text += "<li class=\"has-submenu\">";
                    //ltrTopRight.Text += "<a href=\"/thanh-toan-ho\"><i class=\"fa fa-usd\" aria-hidden=\"true\"></i>THANH TOÁN HỘ<span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    //ltrTopRight.Text += "</li>";
                    //ltrTopRight.Text += "<li class=\"has-submenu\">";
                    //ltrTopRight.Text += "<a href=\"/lich-su-giao-dich\"><i class=\"fa fa-money\" aria-hidden=\"true\"></i>TÀI CHÍNH <span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    //ltrTopRight.Text += "</li>";
                    //ltrTopRight.Text += "<li>";
                    //ltrTopRight.Text += "<a href=\"/khieu-nai\"><i class=\"fa fa-exclamation\" aria-hidden=\"true\"></i>KHIẾU NẠI</a>";
                    //ltrTopRight.Text += "</li>";
                    //ltrTopRight.Text += "<li class=\"has-submenu\">";
                    //ltrTopRight.Text += "<a href=\"/thong-tin-nguoi-dung\"><i class=\"fa fa-user\" aria-hidden=\"true\"></i>QUẢN LÝ TÀI KHOẢN <span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    //ltrTopRight.Text += "</li>";
                    //ltrTopRight.Text += "<a class=\"btn-logout-profile\" href=\"/dang-xuat\">ĐĂNG XUẤT</a>";
                    //ltrTopRight.Text += "</ul>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "</div>";
                    //ltrTopRight.Text += "</div>";
                    #endregion
                    #region lấy thông tin mới  1
                    //ltrLoginDesktop.Text += "<div class=\"acc-info hidden-mobile\">";
                    //ltrLoginDesktop.Text += "<a class=\"hl\"><span class=\"icon\"><i class=\"fa fa-user\" aria-hidden =\"true\"></i></span><span class=\"hidden-mobile\"> " + username + "</span></a>";
                    //ltrLoginDesktop.Text += "<div class=\"status\">";
                    //ltrLoginDesktop.Text += "<div class=\"status-wrap\">";
                    //ltrLoginDesktop.Text += "<div class=\"status__header\">";
                    //ltrLoginDesktop.Text += "<h4>" + level + "</h4>";
                    //ltrLoginDesktop.Text += "</div>";
                    //ltrLoginDesktop.Text += "<div class=\"status__body\">";
                    //ltrLoginDesktop.Text += "<div class=\"level\">";
                    //ltrLoginDesktop.Text += "<div class=\"level__info\">";
                    //ltrLoginDesktop.Text += "<p>Level</p>";
                    //ltrLoginDesktop.Text += "<p class=\"rank\">" + level + "</p>";
                    //ltrLoginDesktop.Text += "</div>";
                    //ltrLoginDesktop.Text += "<div class=\"level__process\">";
                    //ltrLoginDesktop.Text += "<span style=\"width: " + tile + "%\"></span>";
                    //ltrLoginDesktop.Text += "</div>";
                    //ltrLoginDesktop.Text += "</div>";
                    //ltrLoginDesktop.Text += "<div class=\"balance\">";
                    //ltrLoginDesktop.Text += "<p>";
                    //ltrLoginDesktop.Text += "Số dư:";
                    //ltrLoginDesktop.Text += "</p>";
                    //ltrLoginDesktop.Text += "<div class=\"balance__number\">";
                    //ltrLoginDesktop.Text += "<p class=\"vnd\">" + string.Format("{0:N0}", acc.Wallet) + " vnđ</p>";
                    ////ltrLoginDesktop.Text += "<p class=\"cny\">2450Y</p>";
                    //ltrLoginDesktop.Text += "</div>";
                    //ltrLoginDesktop.Text += "</div>";
                    //if (acc.RoleID != 1)
                    //{
                    //    ltrLoginDesktop.Text += "<div class=\"links\">";
                    //    ltrLoginDesktop.Text += "   <a href=\"/manager/login\">Quản trị<i class=\"fa fa-caret-right\"></i></a>";
                    //    ltrLoginDesktop.Text += "</div>";
                    //}
                    //ltrLoginDesktop.Text += "<div class=\"links\">";
                    //ltrLoginDesktop.Text += "<a href=\"/thong-tin-nguoi-dung\">Thông tin tài khoản";
                    //ltrLoginDesktop.Text += "<i class=\"fa fa-caret-right\"></i>";
                    //ltrLoginDesktop.Text += "</a>";
                    //ltrLoginDesktop.Text += "</div>";
                    //ltrLoginDesktop.Text += "<div class=\"links\">";
                    //ltrLoginDesktop.Text += "<a href=\"/danh-sach-don-hang?t=1\">Đơn hàng của bạn";
                    //ltrLoginDesktop.Text += "<i class=\"fa fa-caret-right\"></i>";
                    //ltrLoginDesktop.Text += "</a>";
                    //ltrLoginDesktop.Text += "</div>";
                    //ltrLoginDesktop.Text += "<div class=\"links\">";
                    //ltrLoginDesktop.Text += "<a href=\"/lich-su-giao-dich\">Lịch sử giao dịch";
                    //ltrLoginDesktop.Text += "<i class=\"fa fa-caret-right\"></i>";
                    //ltrLoginDesktop.Text += "</a>";
                    //ltrLoginDesktop.Text += "</div>";
                    //ltrLoginDesktop.Text += "</div>";
                    //ltrLoginDesktop.Text += "<div class=\"status__footer\">";
                    //ltrLoginDesktop.Text += "<a href=\"/dang-xuat\" class=\"ft-btn\">ĐĂNG XUẤT</a>";
                    //ltrLoginDesktop.Text += "</div>";
                    //ltrLoginDesktop.Text += "</div>";
                    //ltrLoginDesktop.Text += "</div>";
                    //ltrLoginDesktop.Text += "</div>";

                    //ltrLoginMobile.Text += "<div class=\"menu-profile\">";
                    //ltrLoginMobile.Text += "<div class=\"nav-overlay\"></div>";
                    //ltrLoginMobile.Text += "<div class=\"profile-content\">";
                    //ltrLoginMobile.Text += "<div class=\"profile-top\">";
                    //ltrLoginMobile.Text += "<div class=\"avatar\">";
                    //ltrLoginMobile.Text += "<a href=\"/thong-tin-nguoi-dung\"><img src=\"" + userIMG + "\"></a>";
                    //ltrLoginMobile.Text += "</div>";
                    //ltrLoginMobile.Text += "<div class=\"info-user-top\">";
                    //ltrLoginMobile.Text += "<a class=\"user_name\" href=\"/thong-tin-nguoi-dung\">" + username + "</a>";
                    //ltrLoginMobile.Text += "<div class=\"info-user\">";
                    //ltrLoginMobile.Text += "<a href=\"#\">";
                    //ltrLoginMobile.Text += "<span class=\"name\">Số tiền: </span>";
                    //ltrLoginMobile.Text += "<span class=\"value\">" + string.Format("{0:N0}", acc.Wallet) + " vnđ</span>";
                    //ltrLoginMobile.Text += "<span class=\"name\"> | Level: <span class=\"value color_orther\">" + level + "</span></span>";
                    //ltrLoginMobile.Text += "</a>";
                    //ltrLoginMobile.Text += "<div class=\"nav-percent\">";
                    //ltrLoginMobile.Text += "<div class=\"nav-percent-ok\" style=\"width: " + tile + "%\"></div>";
                    //ltrLoginMobile.Text += "</div>";
                    //ltrLoginMobile.Text += "</div>";
                    //ltrLoginMobile.Text += "</div>";
                    //ltrLoginMobile.Text += "</div>";
                    //ltrLoginMobile.Text += "<div class=\"profile-bottom\">";
                    //ltrLoginMobile.Text += "<ul class=\"menu-in-profile\">";
                    //ltrLoginMobile.Text += "<li>";
                    //ltrLoginMobile.Text += "<a href=\"/\"><i class=\"fa fa-home\" aria-hidden=\"true\"></i>TRANG CHỦ</a>";
                    //ltrLoginMobile.Text += "</li>";
                    //ltrLoginMobile.Text += "<li>";
                    //ltrLoginMobile.Text += "<a href=\"/theo-doi-mvd\"><i class=\"fa fa-search\" aria-hidden=\"true\"></i>TRACKING</a>";
                    //ltrLoginMobile.Text += "</li>";
                    //ltrLoginMobile.Text += "<li class=\"has-submenu\">";
                    //ltrLoginMobile.Text += "<a href=\"/danh-sach-don-hang?t=1\"><i class=\"fa fa-home\" aria-hidden=\"true\"></i>MUA HÀNG HỘ  <span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    ////ltrLoginMobile.Text += "<ul class=\"sub-menu\">";
                    ////ltrLoginMobile.Text += "<li>";
                    ////ltrLoginMobile.Text += "<a href=\"/tao-don-hang-khac\">Đặt hàng ngoài hệ thống</a>";
                    ////ltrLoginMobile.Text += "</li>";
                    //ltrLoginMobile.Text += "<li>";
                    //ltrLoginMobile.Text += "<a href=\"/danh-sach-don-hang?t=1\">Đơn hàng</a>";
                    //ltrLoginMobile.Text += "</li>";
                    ////ltrLoginMobile.Text += "<li><a href=\"/danh-sach-don-hang?t=3\">Đơn hàng thương mại điện tử khác</a></li>";
                    //ltrLoginMobile.Text += "</ul>";
                    //ltrLoginMobile.Text += "</li>";
                    ////ltrLoginMobile.Text += "<li class=\"has-submenu\">";
                    ////ltrLoginMobile.Text += "<a href=\"/danh-sach-don-van-chuyen-ho\"><i class=\"fa fa-truck\" aria-hidden=\"true\"></i>VẬN CHUYỂN HỘ<span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    ////ltrLoginMobile.Text += "</li>";
                    ////ltrLoginMobile.Text += "<li class=\"has-submenu\">";
                    ////ltrLoginMobile.Text += "<a href=\"/thanh-toan-ho\"><i class=\"fa fa-usd\" aria-hidden=\"true\"></i>THANH TOÁN HỘ<span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    ////ltrLoginMobile.Text += "</li>";
                    //ltrLoginMobile.Text += "<li class=\"has-submenu\">";
                    //ltrLoginMobile.Text += "<a href=\"/lich-su-giao-dich\"><i class=\"fa fa-money\" aria-hidden=\"true\"></i>TÀI CHÍNH <span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    //ltrLoginMobile.Text += "</li>";
                    //ltrLoginMobile.Text += "<li>";
                    //ltrLoginMobile.Text += "<a href=\"/khieu-nai\"><i class=\"fa fa-exclamation\" aria-hidden=\"true\"></i>KHIẾU NẠI</a>";
                    //ltrLoginMobile.Text += "</li>";
                    //ltrLoginMobile.Text += "<li class=\"has-submenu\">";
                    //ltrLoginMobile.Text += "<a href=\"/thong-tin-nguoi-dung\"><i class=\"fa fa-user\" aria-hidden=\"true\"></i>QUẢN LÝ TÀI KHOẢN <span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    //ltrLoginMobile.Text += "</li>";
                    //ltrLoginMobile.Text += "<a class=\"btn-logout-profile\" href=\"/dang-xuat\">ĐĂNG XUẤT</a>";
                    //ltrLoginMobile.Text += "</ul>";
                    //ltrLoginMobile.Text += "</div>";
                    //ltrLoginMobile.Text += "</div>";
                    //ltrLoginMobile.Text += "</div>";
                    //ltrLoginMobile.Text += "</div>";
                    #endregion

                    #region Lấy thông tin mới 2
                    //ltrLogin.Text += "<div class=\"acc-info\">";
                    //ltrLogin.Text += "	<a class=\"acc-info-btn\" href=\"#\"><i class=\"icon fas fa-user\"></i><span>" + username + "</span></a>";
                    //ltrLogin.Text += "	<div class=\"status-desktop\">";
                    //ltrLogin.Text += "		<div class=\"status-wrap\">";
                    //ltrLogin.Text += "			<div class=\"status__header\"><h4>" + level + "</h4></div>";
                    //ltrLogin.Text += "			<div class=\"status__body\">";
                    //ltrLogin.Text += "				<div class=\"level\">";
                    //ltrLogin.Text += "					<div class=\"level__info\"><p>Level</p><p class=\"rank\">" + level + "</p></div>";
                    //ltrLogin.Text += "					<div class=\"level__process\"><span style=\"width: " + tile + "%\"></span></div>";
                    //ltrLogin.Text += "				</div>";
                    //ltrLogin.Text += "				<div class=\"balance\">";
                    //ltrLogin.Text += "					<p>Số dư:</p>";
                    //ltrLogin.Text += "					<div class=\"balance__number\"><p class=\"vnd\">" + string.Format("{0:N0}", acc.Wallet) + " vnđ</p></div>";
                    //ltrLogin.Text += "				</div>";
                    //if (acc.RoleID != 1)
                    //    ltrLogin.Text += "				<div class=\"links\"> <a href=\"/manager/login\">Quản trị<i class=\"fa fa-caret-right\"></i></a></div>";
                    //ltrLogin.Text += "				<div class=\"links\"><a href=\"/thong-tin-nguoi-dung\">Thông tin tài khoản<i class=\"fa fa-caret-right\"></i></a></div>";
                    //ltrLogin.Text += "				<div class=\"links\"><a href=\"/danh-sach-don-hang?t=1\">Đơn hàng của bạn<i class=\"fa fa-caret-right\"></i></a></div>";
                    //ltrLogin.Text += "				<div class=\"links\"><a href=\"/lich-su-giao-dich\">Lịch sử giao dịch<i class=\"fa fa-caret-right\"></i></a></div>";
                    //ltrLogin.Text += "			</div>";
                    //ltrLogin.Text += "			<div class=\"status__footer\"><a href=\"/dang-xuat\" class=\"ft-btn\">ĐĂNG XUẤT</a></div>";
                    //ltrLogin.Text += "		</div>";
                    //ltrLogin.Text += "	</div>";
                    //ltrLogin.Text += "	<div class=\"status-mobile\">";
                    //ltrLogin.Text += "		<a href=\"/\" class=\"user-menu-logo\"><img src=\"/App_Themes/kgn/images/logo.png\" alt=\"\"></a>";
                    //ltrLogin.Text += "		<h3 class=\"username\">" + username + "</h3>";
                    //ltrLogin.Text += "		<div class=\"user-info\">Số tiền: <span class=\"money\">" + string.Format("{0:N0}", acc.Wallet) + "</span> vnđ | Level <span class=\"vip\">" + level + "</span></div>";
                    //ltrLogin.Text += "		<div class=\"nav-percent\"><div class=\"nav-percent-ok\" style=\"width: " + tile + "%\"></div></div>";
                    //ltrLogin.Text += "		<div class=\"profile-bottom\">";
                    //ltrLogin.Text += "			<ul class=\"menu-in-profile\">";
                    //ltrLogin.Text += "				<li><a href=\"/\"><i class=\"fas fa-home\"></i>TRANG CHỦ</a></li>";
                    //ltrLogin.Text += "				<li><a href=\"/theo-doi-mvd\"><i class=\"fas fa-search\"></i>TRACKING</a></li>";
                    //ltrLogin.Text += "				<li class=\"has-submenu\"><a href=\"/danh-sach-don-hang?t=1\"><i class=\"fa fa-home\" aria-hidden=\"true\"></i>MUA HÀNG HỘ  <span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    //ltrLogin.Text += "                  <ul class=\"sub-menu\">";
                    //ltrLogin.Text += "                      <li>";
                    //ltrLogin.Text += "                          <a href=\"/tao-don-hang-khac\">Đặt hàng ngoài hệ thống</a>";
                    //ltrLogin.Text += "                      </li>";
                    //ltrLogin.Text += "                      <li>";
                    //ltrLogin.Text += "                          <a href=\"/danh-sach-don-hang?t=1\">Đơn hàng</a>";
                    //ltrLogin.Text += "                      </li>";
                    //ltrLogin.Text += "                      <li><a href=\"/danh-sach-don-hang?t=3\">Đơn hàng thương mại điện tử khác</a></li>";
                    //ltrLogin.Text += "                  </ul>";
                    //ltrLogin.Text += "              </li>";
                    //ltrLogin.Text += "              <li class=\"has-submenu\">";
                    //ltrLogin.Text += "                  <a href=\"/danh-sach-don-van-chuyen-ho\"><i class=\"fa fa-truck\" aria-hidden=\"true\"></i>VẬN CHUYỂN HỘ<span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    //ltrLogin.Text += "              </li>";
                    //ltrLogin.Text += "              <li class=\"has-submenu\">";
                    //ltrLogin.Text += "                  <a href=\"/thanh-toan-ho\"><i class=\"fa fa-usd\" aria-hidden=\"true\"></i>THANH TOÁN HỘ<span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    //ltrLogin.Text += "              </li>";
                    //ltrLogin.Text += "				<li><a href=\"/lich-su-giao-dich\"><i class=\"fas fa-money-bill\"></i>TÀI CHÍNH</a></li>";
                    //ltrLogin.Text += "				<li><a href=\"/khieu-nai\"><i class=\"fas fa-exclamation\"></i>KHIẾU NẠI</a></li>";
                    //ltrLogin.Text += "				<li><a href=\"/thong-tin-nguoi-dung\"><i class=\"fas fa-user\"></i>QUẢN LÝ TÀI KHOẢN</a></li>";
                    //ltrLogin.Text += "			</ul>";
                    //ltrLogin.Text += "		</div>";
                    //ltrLogin.Text += "		<a href=\"/dang-xuat\" class=\"main-btn\">Đăng xuất</a>";
                    //ltrLogin.Text += "	</div>";
                    //ltrLogin.Text += "	<div class=\"overlay-status-mobile\"></div>";
                    //ltrLogin.Text += "</div>";
                    #endregion

                    #region Lấy Thông tin mới 3
                    ltrLogin.Text += "<div class=\"acc-info\">";
                    ltrLogin.Text += "	<p class=\"user\">" + username + " <i class=\"fas fa-chevron-down color1\"></i></p>";
                    ltrLogin.Text += "	<div class=\"status\">";
                    ltrLogin.Text += "		<div class=\"status-wrap\">";
                    ltrLogin.Text += "			<div class=\"status__header\"><h4>" + level + "</h4></div>";
                    ltrLogin.Text += "			<div class=\"status__body\">";
                    ltrLogin.Text += "				<div class=\"level\">";
                    ltrLogin.Text += "					<div class=\"level__info\"><p>Level</p><p class=\"rank\">" + level + "</p></div>";
                    ltrLogin.Text += "					<div class=\"level__process\"><span style=\"width: " + tile + "%\"></span></div>";
                    ltrLogin.Text += "				</div>";
                    ltrLogin.Text += "				<div class=\"balance\">";
                    ltrLogin.Text += "					<p>Số dư:</p>";
                    ltrLogin.Text += "					<div class=\"balance__number\">";
                    ltrLogin.Text += "						<p class=\"vnd\">" + string.Format("{0:N0}", acc.Wallet) + " đ</p>";
                    //ltrLogin.Text += "						<p class=\"cny\">2450Y</p>";
                    ltrLogin.Text += "					</div>";
                    ltrLogin.Text += "				</div>";
                    if (acc.RoleID != 1)
                        ltrLogin.Text += "				<div class=\"links\"> <a href=\"/manager/login\">Quản trị <i class=\"fa fa-caret-right\"></i></a></div>";
                    ltrLogin.Text += "				<div class=\"links\"><a href=\"/thong-tin-nguoi-dung\">Thông tin tài khoản <i class=\"fa fa-caret-right\"></i></a></div>";
                    ltrLogin.Text += "				<div class=\"links\"><a href=\"/danh-sach-don-hang?t=1\">Đơn hàng của bạn <i class=\"fa fa-caret-right\"></i></a></div>";
                    ltrLogin.Text += "				<div class=\"links\"><a href=\"/lich-su-giao-dich\">Lịch sử giao dịch <i class=\"fa fa-caret-right\"></i></a></div>";
                    ltrLogin.Text += "			</div>";
                    ltrLogin.Text += "			<div class=\"status__footer\"><a href=\"/dang-xuat\" class=\"ft-btn\">ĐĂNG XUẤT</a></div>";
                    ltrLogin.Text += "		</div>";
                    ltrLogin.Text += "	</div>";
                    ltrLogin.Text += "	<div class=\"status-mobile\">";
                    ltrLogin.Text += "		<a href=\"#\" class=\"user-menu-logo\"><img src=\"/App_Themes/giaothuong24h/images/logo.png\" alt=\"\"></a>";
                    ltrLogin.Text += "		<h3 class=\"username\">" + username + "</h3>";
                    ltrLogin.Text += "		<div class=\"user-info\">Số tiền: <span class=\"money\">" + string.Format("{0:N0}", acc.Wallet) + "</span> vnđ | Level <span class=\"vip\">" + level + "</span></div>";
                    ltrLogin.Text += "		<div class=\"nav-percent\"><div class=\"nav-percent-ok\" style=\"width: " + tile + "%\"></div></div>";
                    ltrLogin.Text += "		<div class=\"profile-bottom\">";
                    ltrLogin.Text += "			<ul class=\"menu-in-profile\">";
                    ltrLogin.Text += "				<li><a href=\"/\"><i class=\"fas fa-home\"></i>TRANG CHỦ</a></li>";
                    ltrLogin.Text += "				<li><a href=\"/theo-doi-mvd\"><i class=\"fas fa-search\"></i>TRACKING</a></li>";
                    ltrLogin.Text += "				<li class=\"has-submenu\"><a href=\"/danh-sach-don-hang?t=1\"><i class=\"fa fa-home\" aria-hidden=\"true\"></i>MUA HÀNG HỘ  <span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    ltrLogin.Text += "                  <ul class=\"sub-menu\">";
                    ltrLogin.Text += "                      <li>";
                    ltrLogin.Text += "                          <a href=\"/tao-don-hang-khac\">Đặt hàng ngoài hệ thống</a>";
                    ltrLogin.Text += "                      </li>";
                    ltrLogin.Text += "                      <li>";
                    ltrLogin.Text += "                          <a href=\"/danh-sach-don-hang?t=1\">Đơn hàng</a>";
                    ltrLogin.Text += "                      </li>";
                    ltrLogin.Text += "                      <li><a href=\"/danh-sach-don-hang?t=3\">Đơn hàng thương mại điện tử khác</a></li>";
                    ltrLogin.Text += "                  </ul>";
                    ltrLogin.Text += "              </li>";
                    ltrLogin.Text += "              <li class=\"has-submenu\">";
                    ltrLogin.Text += "                  <a href=\"/danh-sach-don-van-chuyen-ho\"><i class=\"fa fa-truck\" aria-hidden=\"true\"></i>VẬN CHUYỂN HỘ<span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    ltrLogin.Text += "              </li>";
                    ltrLogin.Text += "              <li class=\"has-submenu\">";
                    ltrLogin.Text += "                  <a href=\"/thanh-toan-ho\"><i class=\"fa fa-usd\" aria-hidden=\"true\"></i>THANH TOÁN HỘ<span class=\"icon-down-top\"><i class=\"fa fa-chevron-down\" aria-hidden=\"true\"></i><i class=\"fa fa-chevron-up\" aria-hidden=\"true\"></i></span></a>";
                    ltrLogin.Text += "              </li>";
                    ltrLogin.Text += "				<li><a href=\"/lich-su-giao-dich\"><i class=\"fas fa-money-bill\"></i>TÀI CHÍNH</a></li>";
                    ltrLogin.Text += "				<li><a href=\"/khieu-nai\"><i class=\"fas fa-exclamation\"></i>KHIẾU NẠI</a></li>";
                    ltrLogin.Text += "				<li><a href=\"/thong-tin-nguoi-dung\"><i class=\"fas fa-user\"></i>QUẢN LÝ TÀI KHOẢN</a></li>";
                    ltrLogin.Text += "			</ul>";
                    ltrLogin.Text += "		</div>";
                    ltrLogin.Text += "		<a href=\"/dang-xuat\" class=\"main-btn\">Đăng xuất</a>";
                    ltrLogin.Text += "	</div>";
                    ltrLogin.Text += "	<div class=\"overlay-status-mobile\"></div>";
                    ltrLogin.Text += "</div>";
                    #endregion
                }
            }
            else
            {
                ltrLogin.Text += "<div class=\"hdt__auth-block\"><a href=\"/dang-ky\">Đăng ký</a> / <a href=\"/dang-nhap\">Đăng nhập</a></div>";
            }
        }

        #region Translate And Run
        public string TranslateText(string input, string languagePair)
        {
            try
            {
                string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/47.0.2526.106 Safari/537.36";
                request.Method = "GET";
                var content = String.Empty;
                HttpStatusCode statusCode;
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    var contentType = response.ContentType;
                    Encoding encoding = null;
                    if (contentType != null)
                    {
                        var match = Regex.Match(contentType, @"(?<=charset\=).*");
                        if (match.Success)
                            encoding = Encoding.GetEncoding(match.ToString());
                    }

                    encoding = encoding ?? Encoding.UTF8;

                    statusCode = ((HttpWebResponse)response).StatusCode;
                    using (var reader = new StreamReader(stream, encoding))
                        content = reader.ReadToEnd();
                }
                var doc = Dcsoup.Parse(content);
                var scoreDiv = doc.Select("html").Select("span[id=result_box]").Html;
                return scoreDiv;
            }
            catch
            {
                return "";
            }

        }

        public void SearchPage(string page, string text)
        {
            string linkgo = "";
            if (page == "tmall")
            {
                string a = text;
                string textsearch_tmall = GetHashString(a);
                //string fullLinkSearch_tmall = "https://list.tmall.com/search_product.htm?q=" + textsearch_tmall + "&type=p&vmarket=&spm=875.7931836%2FB.a2227oh.d100&from=mallfp..pc_1_searchbutton";
                linkgo = "https://list.tmall.com/search_product.htm?q=" + textsearch_tmall + "&type=p&vmarket=&spm=875.7931836%2FB.a2227oh.d100&from=mallfp..pc_1_searchbutton";
            }
            else if (page == "taobao")
            {
                string a = text;
                string textsearch_taobao = GetHashString(a);
                //string fullLinkSearch_taobao = "https://world.taobao.com/search/search.htm?q=" + textsearch_taobao + "&navigator=all&_input_charset=&spm=a21bp.7806943.20151106.1";
                linkgo = "https://world.taobao.com/search/search.htm?q=" + textsearch_taobao + "&navigator=all&_input_charset=&spm=a21bp.7806943.20151106.1";
                //https://world.taobao.com/search/search.htm?q=%B9%AB%BC%A6&navigator=all&_input_charset=&spm=a21bp.7806943.20151106.1
            }
            else if (page == "1688")
            {
                string a = text;
                string textsearch_1688 = GetHashString(a);
                //string fullLinkSearch_1688 = "https://s.1688.com/selloffer/offer_search.htm?keywords=" + textsearch_1688 + "&button_click=top&earseDirect=false&n=y";
                linkgo = "https://s.1688.com/selloffer/offer_search.htm?keywords=" + textsearch_1688 + "&button_click=top&earseDirect=false&n=y";
            }
            Response.Redirect(linkgo);
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "redirect('" + linkgo + "')", true);
            //ScriptManager.RegisterStartupScript(Page, typeof(Page), "OpenWindow", "redirect('" + linkgo + "');", true);
        }
        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = MD5.Create();  //or use SHA1.Create();
            byte[] bytes = Encoding.GetEncoding("gb2312").GetBytes(inputString);
            return bytes;
        }
        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append("%" + b.ToString("X2"));

            return sb.ToString();
        }
        #endregion
    }
}