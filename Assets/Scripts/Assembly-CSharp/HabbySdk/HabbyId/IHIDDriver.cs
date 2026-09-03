using BestHTTP;
using UnityEngine.Networking;

namespace HabbySdk.HabbyId
{
	public interface IHIDDriver : IChangeUI, IFinishState, ISDKConnect
	{
		string GameId { get; }

		bool ShowRedDot { get; }

		string GetServerUrl();

		string GetGameAccountId();

		void OnHIDStateChange(bool isLogin, string email, string HabbyId);

		string GetCurrentLanguage();

		UnityWebRequest AddHIDHeader(UnityWebRequest request);

		HTTPRequest AddHIDHeader(HTTPRequest request);

		void PrepareConnention();

		string GetSign(string email, string time);

		void RefreshRedDot();
	}
}
