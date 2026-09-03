using System;

namespace Habby.Account.Data
{
	public interface IHIDDataRequest
	{
		void RequestOrLoginHID(string authCode = null, LoginMode mode = LoginMode.BindOrLogin, Action<bool, int> callback = null);
	}
}
