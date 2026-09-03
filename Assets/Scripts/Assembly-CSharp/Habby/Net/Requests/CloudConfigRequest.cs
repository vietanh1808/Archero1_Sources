using Habby.Model;

namespace Habby.Net.Requests
{
	public class CloudConfigRequest : Request
	{
		public ClientData clientData;

		public new ulong userId;

		public long timestamp;
	}
}
