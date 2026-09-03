using System;

namespace HabbySdk.HabbyStore
{
	public class HabbyStoreError
	{
		public enum ErrorType
		{
			InitializationFailed = 0,
			WebViewCreationFailed = 1,
			PaymentFailed = 2,
			NetworkError = 3,
			TokenError = 4,
			UserNotLoggedIn = 5,
			ConfigurationError = 6,
			PlatformNotSupported = 7
		}

		public ErrorType Type { get; set; }

		public string Message { get; set; }

		public Exception Exception { get; set; }

		public HabbyStoreError(ErrorType type, string message, Exception exception = null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
