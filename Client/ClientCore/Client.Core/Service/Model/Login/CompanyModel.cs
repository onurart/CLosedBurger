using Newtonsoft.Json;
namespace Client.Core.Service.Model.Login
{
	public class CompanyModel
	{
		[JsonProperty("CompanyId")] // Match the JSON property name "CompanyId" with this property

		public string CompanyId { get; set; }
	}
}
