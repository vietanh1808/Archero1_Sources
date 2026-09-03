using System;
using System.Collections.Generic;
using Habby.Model;

namespace Habby.Net.Responses
{
	[Serializable]
	public class MailListResponse : MailResponse
	{
		public List<MailData> data;
	}
}
