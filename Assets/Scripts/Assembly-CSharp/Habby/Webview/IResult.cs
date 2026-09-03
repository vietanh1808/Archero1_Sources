using System.Collections.Generic;

namespace Habby.Webview
{
	public interface IResult
	{
		string Error { get; }

		IDictionary<string, string> ErrorDictionary { get; }

		IDictionary<string, object> ResultDictionary { get; }

		string RawResult { get; }

		bool Cancelled { get; }
	}
}
