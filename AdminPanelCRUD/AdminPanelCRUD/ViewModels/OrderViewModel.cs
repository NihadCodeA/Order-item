using Microsoft.Build.Framework;

namespace AdminPanelCRUD.ViewModels
{
    public class OrderViewModel
    {
        public List<CheckoutItemViewModel> CheckoutItems { get; set; }
		public string FullName { get; set; }
		public string Country { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		[Required]
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string ZipCode { get; set; }
		public string Note { get; set; }
	}
}
