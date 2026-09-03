using System.Collections.Generic;
using Habby.Model;

namespace Habby.Net.Responses
{
	public class FindUserResponse : Response
	{
		public string deviceId;

		public string socialId;

		public List<UserData> userData;

		public ClientData clientData;
	}
}
