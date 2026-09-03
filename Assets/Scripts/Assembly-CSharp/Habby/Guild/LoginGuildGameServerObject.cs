using Dxx.Net;
using Habby.Guild.Tool;

namespace Habby.Guild
{
	public class LoginGuildGameServerObject : LoginGuildObject
	{
		private bool isStartLogin;

		protected override void DisposeGC()
		{
		}

		public override bool StartLogin()
		{
			return false;
		}

		private void OnNetComplete(NetResponse response)
		{
		}
	}
}
