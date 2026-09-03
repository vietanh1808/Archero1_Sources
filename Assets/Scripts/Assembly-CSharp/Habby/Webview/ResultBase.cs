using System.Collections.Generic;

namespace Habby.Webview
{
	internal abstract class ResultBase : IInternalResult, IResult
	{
		internal const string ErrorCodeKey = "error_code";

		internal const string ErrorMessageKey = "error_message";

		public virtual string Error { get; protected set; }

		public virtual IDictionary<string, string> ErrorDictionary { get; protected set; }

		public virtual IDictionary<string, object> ResultDictionary { get; protected set; }

		public virtual string RawResult { get; protected set; }

		public virtual bool Cancelled { get; protected set; }

		public virtual string CallbackId { get; protected set; }

		protected long? CanvasErrorCode { get; private set; }
	}
}
