using System;

namespace Habby.Net.Responses
{
	[Serializable]
	public class CooperationResponse : Response
	{
		[Serializable]
		public class DataObject
		{
			public bool isMaster;

			public string anotherUserId;

			public string roomToken;

			public string roomId;

			public string gaHost;

			public int gaPort;
		}

		public DataObject data;
	}
}
