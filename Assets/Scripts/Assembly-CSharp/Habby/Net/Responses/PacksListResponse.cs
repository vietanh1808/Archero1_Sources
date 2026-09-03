using System;

namespace Habby.Net.Responses
{
	[Serializable]
	public class PacksListResponse : MailResponse
	{
		public LocalSave.MainActivityDataOne[] data;
	}
}
