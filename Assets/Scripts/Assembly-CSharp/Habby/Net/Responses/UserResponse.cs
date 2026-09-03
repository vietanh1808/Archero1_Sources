using System.Collections.Generic;
using Habby.Model;

namespace Habby.Net.Responses
{
	public class UserResponse : Response
	{
		public string deviceId;

		public string socialId;

		public List<UserData> userData;

		public ClientData clientData;
	}
}
