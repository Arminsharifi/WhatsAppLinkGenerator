using System.ComponentModel.DataAnnotations;

namespace WhatsAppLinkGenerator.API.Data_Transfer_Objects
{
    public class Link
    {
        [Required]
        [MinLength(5)]
        public string PhoneNumber { get; private set; }
        public string Text { get; private set; } = string.Empty;

        public Link(string phoneNumber, string text)
        {
            PhoneNumber = phoneNumber.Trim();
            Text = text.Trim();
        }

        public void ChangePhoneNumber(string PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }
    }
}