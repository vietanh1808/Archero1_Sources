using Habby.Model;

namespace Habby.Net.Requests
{
	public class CooperationRequest : Request
	{
		public int[][] equippedInfo;

		public ClientData clientData;

		public int ProtocolVersion;
	}
}
