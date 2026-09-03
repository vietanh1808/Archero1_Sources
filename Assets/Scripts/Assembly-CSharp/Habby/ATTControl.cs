using System.Runtime.InteropServices;
using AOT;

namespace Habby
{
	public class ATTControl
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void CallbackHandler(ATTStatus status, string idfa);

		private static CallbackHandler _callback;

		public static bool AuthorizationAvailable => false;

		public static bool IsAdvertisingTrackingEnabled()
		{
			return false;
		}

		public static ATTStatus GetAuthorizationStatus(bool compatible = true)
		{
			return ATTStatus.NotDetermined;
		}

		[MonoPInvokeCallback(typeof(CallbackHandler))]
		private static void Callback(ATTStatus status, string idfa)
		{
		}

		public static void RequestAdvertisingIdentifier(bool compatible, CallbackHandler callback)
		{
		}

		public static void RequestAdvertisingIdentifier(CallbackHandler callback)
		{
		}
	}
}
