using System.Net;
using WhatsAppLinkGenerator.API.Data_Transfer_Objects;

namespace WhatsAppLinkGenerator.API.BLL
{
    internal static class CreateLink
    {
        internal static string GenerateLink(Link linkDTO)
        {
            if (string.IsNullOrWhiteSpace(linkDTO.Text))
                return string.Format("https://wa.me/{0}", linkDTO.PhoneNumber);
            else
                return string.Format("https://wa.me/{0}?text={1}", linkDTO.PhoneNumber, WebUtility.UrlEncode(linkDTO.Text));
        }
    }
}