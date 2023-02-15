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
    public partial class Default6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var ql = StepController.GetAll("");
            if (ql.Count > 0)
            {
                foreach (var q in ql)
                {
                    ltrQuyTrinh.Text += "<div class=\"faqs-item\">";
                    ltrQuyTrinh.Text += "<h4 class=\"faqs-title\">" + q.StepName + " </h4>";
                    ltrQuyTrinh.Text += "<div class=\"faqs-content\">" + q.StepContent + "</div>";
                    ltrQuyTrinh.Text += "</div>";
                }
            }

            var ck = CustomerBenefitsController.GetAllByItemType(1);
            if (ck.Count > 0)
            {
                foreach (var c in ck)
                {
                    ltrCK.Text += "<div class=\"intro-item\">";
                    ltrCK.Text += "<div class=\"intro-icon\">";
                    ltrCK.Text += "<img src=\"" + c.Icon + "\" alt=\"\">";
                    ltrCK.Text += "</div>";
                    ltrCK.Text += "<h3 class=\"intro-title\">" + c.CustomerBenefitName + "</h4>";
                    ltrCK.Text += "<div class=\"intro-desc\">" + c.CustomerBenefitDescription + "</div>";
                    ltrCK.Text += "</div>";
                }
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
                // if (!string.IsNullOrEmpty(popup))
                if (popup != "<p><br data-mce-bogus=\"1\"></p>")
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

        [WebMethod]
        public static string getInfo(string ordecode)
        {
            string returnString = "";
            var smallpackage = SmallPackageController.GetByOrderTransactionCode(ordecode);
            if (smallpackage != null)
            {
                int mID = 0;
                int tID = 0;
                if (smallpackage.MainOrderID != null)
                {
                    if (smallpackage.MainOrderID > 0)
                    {
                        mID = Convert.ToInt32(smallpackage.MainOrderID);
                    }
                    else if (smallpackage.TransportationOrderID != null)
                    {
                        if (smallpackage.TransportationOrderID > 0)
                        {
                            tID = Convert.ToInt32(smallpackage.TransportationOrderID);
                        }
                    }
                }
                else if (smallpackage.TransportationOrderID != null)
                {
                    if (smallpackage.TransportationOrderID > 0)
                    {
                        tID = Convert.ToInt32(smallpackage.TransportationOrderID);
                    }
                }
                string ordertype = "Chưa xác định";
                if (tID > 0)
                {
                    ordertype = "Đơn hàng vận chuyển hộ";
                }
                else if (mID > 0)
                {
                    ordertype = "Đơn hàng mua hộ";
                }

                returnString += "<aside style=\"text-align:left;\" class=\"side trk-info fr\"><table>";
                returnString += "   <tbody>";
                returnString += "       <tr>";
                returnString += "           <th style=\"width:50%\">Mã vận đơn:</th>";
                returnString += "           <td class=\"m-color\">" + ordecode + "</td>";
                returnString += "       </tr>";
                returnString += "       <tr>";
                returnString += "           <th style=\"width:50%\">ID đơn hàng:</th>";
                if (mID > 0)
                    returnString += "           <td class=\"m-color\">" + mID + "</td>";
                else if (tID > 0)
                    returnString += "           <td class=\"m-color\">" + tID + "</td>";
                else
                    returnString += "           <td class=\"m-color\">Chưa xác định</td>";
                returnString += "       </tr>";
                returnString += "       <tr>";
                returnString += "           <th style=\"width:50%\">Loại đơn hàng:</th>";
                returnString += "           <td class=\"m-color\">" + ordertype + "</td>";
                returnString += "       </tr>";
                returnString += "   </tbody>";
                returnString += "</table></aside>";
                returnString += "<aside class=\"side trk-history fl\"><ul class=\"list\">";
                if (smallpackage.Status == 0)
                {
                    returnString += "<li class=\"clear\">";
                    returnString += "  Mã vận đơn đã bị hủy";
                    returnString += "</li>";
                }
                else if (smallpackage.Status == 1)
                {
                    returnString += "<li class=\"clear\">";
                    returnString += "  Mã vận đơn chưa về kho TQ";
                    returnString += "</li>";
                }
                else if (smallpackage.Status == 2)
                {
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInTQWarehouse != null)
                        returnString += "  <div class=\"date-time tq grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInTQWarehouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <p class=\"tit\"><span class=\"grey89 font-w\">Trạng thái:</span><span class=\"m-color\"> Đã về kho TQ</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89 font-w\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffTQWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                }
                else if (smallpackage.Status == 3)
                {
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInTQWarehouse != null)
                        returnString += "  <div class=\"date-time tq grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInTQWarehouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <p class=\"tit\"><span class=\"grey89 font-w\">Trạng thái:</span><span class=\"m-color\"> Đã về kho TQ</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89 font-w\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffTQWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInLasteWareHouse != null)
                        returnString += "  <div class=\"date-time vn grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInLasteWareHouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <p class=\"tit\"><span class=\"grey89 font-w\">Trạng thái:</span><span class=\"m-color\"> Đã về kho đích</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89 font-w\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffVNWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                }
                else if (smallpackage.Status == 4)
                {
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInTQWarehouse != null)
                        returnString += "  <div class=\"date-time tq grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInTQWarehouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <p class=\"tit\"><span class=\"grey89 font-w\">Trạng thái:</span><span class=\"m-color\"> Đã về kho TQ</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89 font-w\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffTQWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInLasteWareHouse != null)
                        returnString += "  <div class=\"date-time vn grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInLasteWareHouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <p class=\"tit\"><span class=\"grey89 font-w\">Trạng thái:</span><span class=\"m-color\"> Đã về kho đích</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89 font-w\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffVNWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateOutWarehouse != null)
                        returnString += "  <div class=\"date-time ht grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateOutWarehouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <p class=\"tit\"><span class=\"grey89 font-w\">Trạng thái:</span><span class=\"m-color\"> Đã giao khách</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89 font-w\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffVNOutWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                }
                returnString += "</ul></aside>";
            }
            else
            {
                returnString += "Không tồn tại mã vận đơn trong hệ thống";
            }
            return returnString;
        }
        public class NotiInfo
        {
            public string NotiTitle { get; set; }
            public string NotiContent { get; set; }
            public string NotiEmail { get; set; }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtSearch.Text.Trim();
                if (!string.IsNullOrEmpty(text))
                {
                    string a = PJUtils.TranslateTextNew(text, "vi", "zh");
                    a = a.Replace("[", "").Replace("]", "").Replace("\"", "");
                    string[] ass = a.Split(',');
                    string page = hdfWebsearch.Value;
                    SearchPage(page, PJUtils.RemoveHTMLTags(ass[0]));
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}