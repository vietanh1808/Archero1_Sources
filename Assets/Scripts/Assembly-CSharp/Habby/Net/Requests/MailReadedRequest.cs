using Habby.Model;

namespace Habby.Net.Requests
{
	public class MailReadedRequest : MailRequest
	{
		public string mailId;

		public int mailScope;

		public UserData userData;
	}
}
