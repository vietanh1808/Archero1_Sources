using System;
using System.Collections.Generic;

namespace Habby.Webview
{
	public class AppLinkResult : IAppLinkResult, IResult
	{
		public Uri Uri { get; private set; }

		public IDictionary<string, string> Queries { get; private set; }

		public string Error => null;

		public IDictionary<string, string> ErrorDictionary => null;

		public IDictionary<string, object> ResultDictionary => null;

		public string RawResult => null;

		public bool Cancelled => false;

		internal AppLinkResult(Uri uri)
		{
		}
	}
}
