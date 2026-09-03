using System;

namespace Habby.Net.Responses
{
	[Serializable]
	public class CooperationMatchIsOpenResponse : Response
	{
		[Serializable]
		public class DataObject
		{
			public int waiting;
		}

		public DataObject data;
	}
}
