using System;
using System.Collections.Generic;

namespace Habby.Webview
{
	public interface IAppLinkResult : IResult
	{
		Uri Uri { get; }

		IDictionary<string, string> Queries { get; }
	}
}
