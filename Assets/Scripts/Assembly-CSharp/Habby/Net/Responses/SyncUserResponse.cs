using Habby.Model;

namespace Habby.Net.Responses
{
	public class SyncUserResponse : Response
	{
		public string deviceId;

		public string socialId;

		public UserData userData;

		public ClientData clientData;
	}
}
