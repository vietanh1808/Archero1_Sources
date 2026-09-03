using System.Collections.Generic;
using Cooperation.NetData;

namespace Cooperation.NetEvent
{
	public class SCStartMatchEvent
	{
		public uint code;

		public string gaHost;

		public int gaPort;

		public string roomId;

		public string roomToken;

		public List<string> mapIds;

		public ulong anotherUserId;

		public bool isMaster;

		public int integralFactor;

		public PlayerInfoData infoData;
	}
}
