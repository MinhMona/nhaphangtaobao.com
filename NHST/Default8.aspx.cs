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
    public partial class Default5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                LoadData();
                //Response.Redirect("/dang-nhap");
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

                //ltrAddress.Text += "<p>" + confi.Address2 + "</p>";
                //ltrHotline.Text += "<p><a href=\"tel:" + hotline + "\">" + hotline + "</a></p>";
                //ltrEmail.Text += "<p><a href=\"mailto:" + email + "\">" + email + "</a></p>";
                //ltrTimeWork.Text += "<p>" + timework + "</p>";
            }

            #region Lấy thông tin trang chủ
            var steps = StepController.GetAll("");
            if (steps.Count > 0)
            {
                int count = 1;
                foreach (var item in steps)
                {
                    string name = item.StepName;
                    string namenotdau = LeoUtils.ConvertToUnSign(name);

                    if (count == 1)
                    {
                        // ltrStep1.Text += "<li class=\"tab-link current\" data-tab=\"#step-" + count + "\">";
                    }
                    else
                    {
                        //ltrStep1.Text += "<li class=\"tab-link\" data-tab=\"#step-" + count + "\">";
                    }

                    //ltrStep1.Text += "<div class=\"step-nav-item\">";
                    //ltrStep1.Text += "<div class=\"step-nav-icon\"><img src=\"" + item.StepIMG + "\" alt=\"\"></div>";
                    //ltrStep1.Text += "<div class=\"step-nav-decor\"></div>";
                    //ltrStep1.Text += "<p class=\"step-nav-title\">" + item.StepName + "</p>";
                    //ltrStep1.Text += "</div>";
                    //ltrStep1.Text += "</li>";

                    if (count == 1)
                    {
                        // ltrStep2.Text += "<div id=\"step-" + count + "\" class=\"tab-content\" data-wow-delay=\".2s\">";
                    }
                    else
                    {
                        // ltrStep2.Text += "<div id=\"step-" + count + "\" class=\"tab-content\" data-wow-delay=\".2s\">";
                    }
                    //ltrStep2.Text += "<div class=\"step-item\">";
                    //ltrStep2.Text += "<div class=\"columns\">";
                    //ltrStep2.Text += "<div class=\"column left\">";
                    //ltrStep2.Text += "<p class=\"step-title\">" + item.StepName + "</p>";
                    //ltrStep2.Text += "<div class=\"step-desc\">" + item.StepContent + "</div>";
                    //ltrStep2.Text += "<a class=\"main-btn main-btn-2\" href=\"" + item.StepLink + "\">Chi tiết</a>";
                    //ltrStep2.Text += "</div>";
                    //ltrStep2.Text += "<div class=\"column right\">";
                    //ltrStep2.Text += "<div class=\"step-img\"><img src=\"/App_Themes/vanchuyenviettrung/images/mac.png\" alt=\"\"></div>";

                    //ltrStep2.Text += "</div>";
                    //ltrStep2.Text += "</div>";
                    //ltrStep2.Text += "</div>";
                    //ltrStep2.Text += "</div>";
                    count++;
                }
            }

            //var services = ServiceController.GetAll().OrderBy(x => x.Position).ToList();
            //if (services.Count > 0)
            //{

            //    for (int i = 0; i < services.Count; i++)
            //    {

            //        var item = services[i];
            //        if (item != null)
            //        {


            //            //ltrService.Text += "<div class=\"column\">";
            //            //ltrService.Text += "<div class=\"services-item\">";
            //            //ltrService.Text += "<div class=\"services-icon\"><img src=\"" + item.ServiceIMG + "\" alt=\"\"></div>";
            //            //ltrService.Text += "<h4 class=\"services-title\">" + item.ServiceName + "</h4>";
            //            //ltrService.Text += "<div class=\"services-desc\">" + item.ServiceContent + "</div>";
            //            //ltrService.Text += "</div>";
            //            //ltrService.Text += "</div>";


            //        }
            //    }
            //}


            var teamlist = TeamWorkController.GetAllByType(1);
            if (teamlist.Count > 0)
            {
                foreach (var item in teamlist)
                {
                    ltrTeamList.Text += "<li>";
                    ltrTeamList.Text += "<div class=\"hotline-icon\"><img src=\"/App_Themes/conduongtolua/images/zalo.png\" alt=\"\"></div>";
                    ltrTeamList.Text += "<div class=\"hotline-info\">";
                    //ltrTeamList.Text += "<div class=\"our-team-item\">";
                    //ltrTeamList.Text += "<div class=\"avatar ratio-box\"><img src=\"" + item.IMG + "\" alt=\"\"></div>";
                    ltrTeamList.Text += "<p class=\"title\">" + item.Name + "</p>";
                    ltrTeamList.Text += "<p class=\"number\">" + item.Description + "</p>";
                    //ltrTeamList.Text += "</div>";
                    ltrTeamList.Text += "</div>";
                    ltrTeamList.Text += "</li>";
                }
            }

            var feedback = TeamWorkController.GetAllByType(3);
            if (feedback.Count > 0)
            {
                foreach (var item in feedback)
                {
                    ltrCustomerFeedback.Text += "<div class=\"slide-item\">";
                    ltrCustomerFeedback.Text += "<div class=\"feedback-item\">";
                    ltrCustomerFeedback.Text += "<div class=\"feedback-content\">" + item.Description + "</div>";
                    ltrCustomerFeedback.Text += "<div class=\"feedback-author\">";
                    ltrCustomerFeedback.Text += "<div class=\"avatar\"><img src=\"" + item.IMG + "\" alt=\"\"></div>";
                    ltrCustomerFeedback.Text += "<div class=\"info\">";
                    ltrCustomerFeedback.Text += "<p class=\"name\">" + item.Name + "</p>";
                    ltrCustomerFeedback.Text += "</div>";
                    ltrCustomerFeedback.Text += "</div>";
                    ltrCustomerFeedback.Text += "</div>";
                    ltrCustomerFeedback.Text += "</div>";
                }
            }

            var services = ServiceController.GetAll();
            if (services.Count > 0)
            {
                int count = 1;
                foreach (var sv in services)
                {
                    string name = sv.ServiceName;
                    string namenotdau = LeoUtils.ConvertToUnSign(name);

                    if (count == 1)
                    {
                        ltrService1.Text += "<li class=\"tab-link current\" data-tab=\"#sv-" + count + "\">";
                    }
                    else
                    {
                        ltrService1.Text += "<li class=\"tab-link\" data-tab=\"#sv-" + count + "\">";
                    }

                    ltrService1.Text += "<div class=\"icon\">";
                    ltrService1.Text += "<img src=\"" + sv.ServiceIMG + "\" alt=\"\">";
                    ltrService1.Text += "<img src=\"" + sv.ServiceIMG + "\" alt=\"\">";
                    ltrService1.Text += "</div>";
                    ltrService1.Text += "<p class=\"title\">" + sv.ServiceName + "</p>";
                    ltrService1.Text += "</li>";

                    if (count == 1)
                    {
                        ltrService2.Text += "<div id=\"sv-" + count + "\" class=\"tab-content\" data-wow-delay=\".2s\">";
                    }
                    else
                    {
                        ltrService2.Text += "<div id=\"sv-" + count + "\" class=\"tab-content\" data-wow-delay=\".2s\">";
                    }

                    ltrService2.Text += "<div class=\"services-item\">";
                    ltrService2.Text += "<div class=\"left-content\">";
                    ltrService2.Text += "<h3 class=\"title\">" + name + "</h3>";
                    ltrService2.Text += "<div class=\"desc\">" + sv.ServiceContent + "</div>";
                    ltrService2.Text += "</div>";
                    ltrService2.Text += "<div class=\"right-img\"><img src=\"/App_Themes/conduongtolua/images/services-img.jpg\" alt=\"\"></div>";
                    ltrService2.Text += "</div>";
                    ltrService2.Text += "</div>";
                    count++;
                }
            }


            var ql = CustomerBenefitsController.GetAllByItemType(2);
            if (ql.Count > 0)
            {
                foreach (var q in ql)
                {
                    ltrQL1.Text += "<div class=\"faqs-item\">";
                    ltrQL1.Text += "<h4 class=\"faqs-title\"><i class=\"fa fa-caret-right\" aria-hidden=\"true\"></i>" + q.CustomerBenefitName + " </h4>";
                    ltrQL1.Text += "<div class=\"faqs-content\">" + q.CustomerBenefitDescription + "</div>";
                    ltrQL1.Text += "</div>";
                }
            }

            var tt = CustomerBenefitsController.GetAllByItemType(3);
            if (tt.Count > 0)
            {
                foreach (var t in tt)
                {
                    Tintuc.Text += "<div class=\"slide-item\">";

                    Tintuc.Text += "<div class=\"news-item\">";
                    Tintuc.Text += "<div class=\"news-img\">";
                    Tintuc.Text += "<a href=\"\" class=\"ratio-box\"><img src=\"" + t.Icon + "\" alt=\"\"></a></div>";
                    Tintuc.Text += "<div class=\"news-info\">";
                    Tintuc.Text += "<h4 class=\"news-title\">" + t.CustomerBenefitName + "</h4>";
                    Tintuc.Text += "<div class=\"news-desc\">" + t.CustomerBenefitDescription + "</div>";
                    Tintuc.Text += "<a href=\"#" + t.CustomerBenefitLink + "\" class=\"readmore-btn\">Xem thêm <i class=\"fa fa-arrow-circle-right\" aria-hidden=\"true\"></i></a>";
                    Tintuc.Text += "</div>";
                    Tintuc.Text += "</div>";
                    Tintuc.Text += "</div>";
                    
                }
            }

            var ck = CustomerBenefitsController.GetAllByItemType(1);
            if (ck.Count > 0)
            {
                foreach (var c in ck)
                {
                    ltrCK.Text += "<div class=\"column\">";
                    ltrCK.Text += "<div class=\"commitment-item\">";
                    ltrCK.Text += "<div class=\"commitment-icon\"><img src=\"" + c.Icon + "\" alt=\"\"></div>";
                    ltrCK.Text += "<h4 class=\"commitment-title\">" + c.CustomerBenefitName + "</h4>";
                    ltrCK.Text += "<div class=\"commitment-desc\">" + c.CustomerBenefitDescription + "</div>";
                    ltrCK.Text += "<a href=\"" + c.CustomerBenefitLink + "\" class=\"readmore-btn\">Xem thêm <i class=\"fa fa-arrow-circle-right\" aria-hidden=\"true\"></i></a>";
                    ltrCK.Text += "</div>";
                    ltrCK.Text += "</div>";
                }
            }
            #endregion

            try
            {
                string weblink = "https://nhaphangdemo.monamedia.net";
                string url = HttpContext.Current.Request.Url.AbsoluteUri;

                HtmlHead objHeader = (HtmlHead)Page.Header;

                //we add meta description
                HtmlMeta objMetaFacebook = new HtmlMeta();

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "fb:app_id");
                objMetaFacebook.Content = "676758839172144";
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:url");
                objMetaFacebook.Content = url;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:type");
                objMetaFacebook.Content = "website";
                objHeader.Controls.Add(objMetaFacebook);


                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:title");
                objMetaFacebook.Content = confi.OGTitle;
                objHeader.Controls.Add(objMetaFacebook);


                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:description");
                objMetaFacebook.Content = confi.OGDescription;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:image");
                objMetaFacebook.Content = weblink + confi.OGImage;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:image:width");
                objMetaFacebook.Content = "200";
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:image:height");
                objMetaFacebook.Content = "500";
                objHeader.Controls.Add(objMetaFacebook);

                HtmlMeta meta = new HtmlMeta();
                meta = new HtmlMeta();
                meta.Attributes.Add("name", "description");
                meta.Content = confi.MetaDescription;

                objHeader.Controls.Add(meta);

                this.Title = confi.MetaTitle;
                //meta = new HtmlMeta();
                //meta.Attributes.Add("name", "title");
                //meta.Content = "Võ Minh Thiên Logistics";
                //objHeader.Controls.Add(meta);


                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "og:title");
                objMetaFacebook.Content = confi.OGTitle;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "twitter:title");
                objMetaFacebook.Content = confi.OGTwitterTitle;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "twitter:description");
                objMetaFacebook.Content = confi.OGTwitterDescription;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "twitter:image");
                objMetaFacebook.Content = weblink + confi.OGTwitterImage;
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "twitter:image:width");
                objMetaFacebook.Content = "200";
                objHeader.Controls.Add(objMetaFacebook);

                objMetaFacebook = new HtmlMeta();
                objMetaFacebook.Attributes.Add("property", "twitter:image:height");
                objMetaFacebook.Content = "500";
                objHeader.Controls.Add(objMetaFacebook);

            }
            catch
            {

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

                returnString += "<aside class=\"side trk-info fr\"><table>";
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
                        returnString += "  <div class=\"date-time grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInTQWarehouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <i class=\"ico fa fa-check\"></i>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">Trạng thái:</span><span class=\"m-color\"> Đã về kho TQ</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffTQWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                }
                else if (smallpackage.Status == 3)
                {
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInTQWarehouse != null)
                        returnString += "  <div class=\"date-time grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInTQWarehouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <i class=\"ico fa fa-check\"></i>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">Trạng thái:</span><span class=\"m-color\"> Đã về kho TQ</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffTQWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInLasteWareHouse != null)
                        returnString += "  <div class=\"date-time grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInLasteWareHouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <i class=\"ico fa fa-check\"></i>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">Trạng thái:</span><span class=\"m-color\"> Đã về kho đích</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffVNWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                }
                else if (smallpackage.Status == 4)
                {
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInTQWarehouse != null)
                        returnString += "  <div class=\"date-time grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInTQWarehouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <i class=\"ico fa fa-check\"></i>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">Trạng thái:</span><span class=\"m-color\"> Đã về kho TQ</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffTQWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateInLasteWareHouse != null)
                        returnString += "  <div class=\"date-time grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateInLasteWareHouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <i class=\"ico fa fa-check\"></i>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">Trạng thái:</span><span class=\"m-color\"> Đã về kho đích</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffVNWarehouse + "</span></p>";
                    returnString += "  </div>";
                    returnString += "</li>";
                    returnString += "<li class=\"it clear\">";
                    if (smallpackage.DateOutWarehouse != null)
                        returnString += "  <div class=\"date-time grey89\"><p>" + string.Format("{0:dd/MM/yyyy HH:mm}", smallpackage.DateOutWarehouse) + "</p></div>";
                    else
                        returnString += "  <div class=\"date-time grey89\"><p>Chưa xác định</p></div>";
                    returnString += "  <div class=\"statuss ok\">";
                    returnString += "      <i class=\"ico fa fa-check\"></i>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">Trạng thái:</span><span class=\"m-color\"> Đã giao khách</span></p>";
                    returnString += "      <p class=\"tit\"><span class=\"grey89\">NV Xử lý:</span> <span class=\"m-color\">" + smallpackage.StaffVNOutWarehouse + "</span></p>";
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