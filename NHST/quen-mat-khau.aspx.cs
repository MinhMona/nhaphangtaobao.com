using NHST.Bussiness;
using NHST.Controllers;
using NHST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZLADIPJ.Business;

namespace NHST
{
    public partial class quen_mat_khau2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Loaddata();
            }
        }
        public void Loaddata()
        {
            var confi = ConfigurationController.GetByTop1();
           // ltrLogo.Text = "  <img src=\"" + confi.LogoIMG + "\" alt=\"\">";
            if (confi != null)
            {
                string hotline = confi.Hotline;
                ltrHotlineCall.Text += "<a href=\"tel:" + hotline + "\" class=\"fancybox\">";
                ltrHotlineCall.Text += "<div class=\"coccoc-alo-phone coccoc-alo-green coccoc-alo-show\" id=\"coccoc-alo-phoneIcon\">";
                ltrHotlineCall.Text += "<div class=\"coccoc-alo-ph-circle\"></div>";
                ltrHotlineCall.Text += "<div class=\"coccoc-alo-ph-circle-fill\"></div>";
                ltrHotlineCall.Text += "<div class=\"coccoc-alo-ph-img-circle\"></div>";
                ltrHotlineCall.Text += "</div>";
                ltrHotlineCall.Text += "</a>";
            }
        }
        protected void btngetpass_Click(object sender, EventArgs e)
        {
            var user = AccountInfoController.GetByEmailFP(txtEmail.Text.Trim());
            if (user != null)
            {
                //string password = PJUtils.RandomStringWithText(10);
                //Send Email pass
                string token = PJUtils.RandomStringWithText(15);
                string BackLink = "/dang-nhap.aspx";
                //Cập nhật pass mới cho user
                //string kq = AccountController.UpdatePassword(Convert.ToInt32(user.UID), password);
                var tk = TokenForgotPassController.Insert(user.UID.Value, token, user.ID.ToString());
                if (tk != null)
                {
                    string link = "<a href=\"https://nhaphangtaobao.com/mat-khau-moi.aspx?token=" + token + "\">đây</a>";
                    try
                    {
                        PJUtils.SendMailGodaddy("admin@nhaphangsieutoc.com", "Nhaphang@123", txtEmail.Text.Trim(),
                            "Reset Mật khẩu trên NHẬP HÀNG TAOBAO",
                            "Bạn vui lòng nhấn vào: <strong>" + link
                            + "</strong>", "");
                    }
                    catch
                    {

                    }
                    PJUtils.ShowMessageBoxSwAlertBackToLink("Hệ thống đã gửi 1 email mới cho bạn, vui lòng kiểm tra email.", "s", true, BackLink, Page);
                }
            }
            else
            {
                PJUtils.ShowMessageBoxSwAlert("Email không tồn tại trong hệ thống.", "e", false, Page);
            }
        }
    }
}