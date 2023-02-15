using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MB.Extensions;
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
    public partial class Default4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "Giao Thương 24h - Trang chủ";
            if (!IsPostBack)
            {
                LoadData();
            }
        }
        public void LoadData()
        {
            var confi = ConfigurationController.GetByTop1();
            if (confi != null)
            {
                string email = confi.EmailSupport;
                string hotline = confi.Hotline;
                string timework = confi.TimeWork;
                ltrFooterAddress.Text += "<p>" + confi.Address + "</p>";
                ltrFooterEmail.Text += "<p><a href=\"mailto:" + email + "\">" + email + "</a></p>";
                ltrFooterTimework.Text += "<p>" + timework + "</p>";
                ltrFooterHotline.Text += "<p><a href=\"tel:" + hotline + "\">" + hotline + "</a></p>";

            }
            #region Lấy thông tin trang chủ
            ///Dịch vụ
            ///
            var services = ServiceController.GetAll();
            if (services.Count > 0)
            {
                int count = 1;
                foreach (var s in services)
                {
                    string serviceLink = "javascript:;";
                    if (!string.IsNullOrEmpty(s.ServiceLink))
                        serviceLink = s.ServiceLink;

                    if (count == 1)
                        ltrService1.Text += "<li class=\"navct-item active\"><a href=\"#service" + count + "\" step-nav=\"#service" + count + "\" class=\"navct-link\">" + s.ServiceName + "</a></li>";
                    else
                        ltrService1.Text += "<li class=\"navct-item\"><a href=\"#service" + count + "\" step-nav=\"#service" + count + "\" class=\"navct-link\">" + s.ServiceName + "</a></li>";
                    ltrService2.Text += "<div class=\"navct-desc\" id=\"service" + count + "\">";
                    ltrService2.Text += "	<div class=\"icon\"><img src=\"" + s.ServiceIMG + "\" alt=\"\"></div>";
                    ltrService2.Text += "	<h3 class=\"hd\">" + s.ServiceName + "</h3>";
                    ltrService2.Text += "	<p>" + s.ServiceContent + "</p>";
                    ltrService2.Text += "	<div class=\"img\"><img src=\"/App_Themes/giaothuong24h/images/services-img1.png\" alt=\"\"></div>";
                    ltrService2.Text += "</div>";
                    count++;
                }
            }

            ///Quy trình
            ///
            var steps = StepController.GetAll("");
            if (steps.Count > 0)
            {
                int count = 1;
                foreach (var s in steps)
                {
                    string name = s.StepName;
                    string namenotdau = LeoUtils.ConvertToUnSign(name);
                    if (count == 1)
                        ltrStep1.Text += "<li class=\"navct-item active\"><a href=\"#order" + count + "\" step-nav=\"#order" + count + "\" class=\"navct-link\">" + name + "</a></li>";
                    else
                        ltrStep1.Text += "<li class=\"navct-item\"><a href=\"#order" + count + "\" step-nav=\"#order" + count + "\" class=\"navct-link\">" + name + "</a></li>";
                    ltrStep2.Text += "<div class=\"navct-desc\" id=\"order" + count + "\">";
                    ltrStep2.Text += "	<div class=\"icon\"><img src=\"" + s.StepIMG + "\" alt=\"\"></div>";
                    ltrStep2.Text += "	<h3 class=\"hd\">" + name + "</h3>";
                    ltrStep2.Text += "	<p>" + s.StepContent + "</p>";
                    if (!string.IsNullOrEmpty(s.StepLink))
                        ltrStep2.Text += "	<a href=\"" + s.StepLink + "\" class=\"mn-btn btn-bg\">Chi tiết</a>";
                    ltrStep2.Text += "	<div class=\"img\"><img src=\"/App_Themes/giaothuong24h/images/step-img1.png\" alt=\"\"></div>";
                    ltrStep2.Text += "</div>";
                    count++;
                }
            }

            ///Quyền lợi khách hàng
            ///
            var ql = CustomerBenefitsController.GetAllByItemType(2);
            if (ql.Count > 0)
            {
                foreach (var q in ql)
                {
                    string bLink = "javascript:;";
                    if (!string.IsNullOrEmpty(q.CustomerBenefitLink))
                        bLink = q.CustomerBenefitLink;

                    ltrQL1.Text += "<li class=\"benefit__item\">";
                    ltrQL1.Text += "	<div class=\"benefit-card\">";
                    ltrQL1.Text += "		<div class=\"img\"><a href=\"" + bLink + "\"><img src=\"" + q.Icon + "\" alt=\"\"></a></div>";
                    ltrQL1.Text += "		<div class=\"content\">";
                    ltrQL1.Text += "			<h4 class=\"hd\"><a href=\"\">" + q.CustomerBenefitName + "</a></h4>";
                    ltrQL1.Text += "			<p>" + q.CustomerBenefitDescription + "</p>";
                    if (!string.IsNullOrEmpty(q.CustomerBenefitLink))
                        ltrQL1.Text += "			<a href=\"" + q.CustomerBenefitLink + "\" class=\"mn-btn btn-right\">Xem thêm</a>";
                    ltrQL1.Text += "		</div>";
                    ltrQL1.Text += "	</div>";
                    ltrQL1.Text += "</li>";

                }
            }
            #endregion
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //Response.Write(txtSearch.Text.Trim());
            //try
            //{
            //    string text = txtSearch.Text.Trim();
            //    if (!string.IsNullOrEmpty(text))
            //    {
            //        string a = PJUtils.TranslateTextNew(text, "vi", "zh");
            //        a = a.Replace("[", "").Replace("]", "").Replace("\"", "");
            //        string[] ass = a.Split(',');
            //        string page = hdfWebsearch.Value;
            //        SearchPage(page, PJUtils.RemoveHTMLTags(ass[0]));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Response.Write(ex.Message);
            //}
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
        [WebMethod]
        public static string closewebinfo()
        {
            HttpContext.Current.Session["infoclose"] = "ok";
            return "ok";
        }
        [WebMethod]
        public static string getPopup()
        {
            if (HttpContext.Current.Session["notshowpopup"] == null)
            {
                var conf = ConfigurationController.GetByTop1();
                string popup = conf.NotiPopup;
                if (!string.IsNullOrEmpty(popup))
                {
                    NotiInfo n = new NotiInfo();
                    n.NotiTitle = conf.NotiPopupTitle;
                    n.NotiEmail = conf.NotiPopupEmail;
                    n.NotiContent = conf.NotiPopup;
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    return serializer.Serialize(n);
                }
                else
                    return "null";
            }
            else
                return null;

        }
        [WebMethod]
        public static void setNotshow()
        {
            HttpContext.Current.Session["notshowpopup"] = "1";
        }
        public class NotiInfo
        {
            public string NotiTitle { get; set; }
            public string NotiContent { get; set; }
            public string NotiEmail { get; set; }
        }
    }
}