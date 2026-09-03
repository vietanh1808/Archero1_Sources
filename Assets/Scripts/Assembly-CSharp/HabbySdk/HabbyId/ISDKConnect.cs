using System;

namespace HabbySdk.HabbyId
{
	public interface ISDKConnect
	{
		bool CheckHabbyIdLogin();

		void LoginHabbyId(string authCode, ProcessType type, Action<bool, int> onResult);

		void LogoutHabbyId(Action<bool, int> onResult);

		string GetCustonUserInfo();

		void TrackEvent(SdkEventName eventName, V2V_TrackSdkEvent eventData = null);
	}
}
