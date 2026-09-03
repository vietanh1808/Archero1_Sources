using Habby.Model;

namespace Habby.Net.Requests
{
	public class MailRewardRequest : MailRequest
	{
		public string mailId;

		public int mailScope;

		public UserData userData;
	}
}
