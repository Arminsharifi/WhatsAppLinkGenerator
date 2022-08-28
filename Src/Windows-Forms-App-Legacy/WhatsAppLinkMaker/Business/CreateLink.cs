using System.Net;

namespace WhatsAppLinkMaker.Business
{
    internal class CreateLink
    {
        internal string fncCreateLink(string strPhoneNumber, string strInputText)
        {
            if (strPhoneNumber.Length < 11 || strPhoneNumber.Length > 12) return "شماره ورودی اشتباه می باشد";
            return string.Format("https://wa.me/{0}?text={1}", "98" + strPhoneNumber.Remove(0, 1), strInputText, WebUtility.UrlEncode(strInputText));
        }
    }
}