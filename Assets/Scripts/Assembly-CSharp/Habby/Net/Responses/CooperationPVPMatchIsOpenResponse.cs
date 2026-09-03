using System;

namespace Habby.Net.Responses
{
	[Serializable]
	public class CooperationPVPMatchIsOpenResponse : Response
	{
		[Serializable]
		public class DataObject
		{
			public bool isMatchOpen;

			public bool isManualMatchOpen;

			public int waiting;
		}

		public DataObject data;
	}
}
