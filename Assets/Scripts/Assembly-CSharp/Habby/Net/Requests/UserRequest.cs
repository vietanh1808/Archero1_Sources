using Habby.Model;

namespace Habby.Net.Requests
{
	public class UserRequest : Request
	{
		public UserData userData;

		public ClientData clientData;

		public string requestId;

		public string requestTimeUTC;

		public int saveCount;
	}
}
