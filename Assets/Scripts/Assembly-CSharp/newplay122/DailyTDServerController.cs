using System;
using GameProtocol;
using XLua;

namespace newplay122
{
	public class DailyTDServerController
	{
		public const ushort REQ_TYPE_INFO = 0;

		public const ushort REQ_TYPE_CHANGE_MAP = 7;

		public const ushort REQ_TYPE_REWARD = 8;

		private static DelegateBridge __Hotfix0_ReqDailyTD;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void ReqDailyTD(ushort reqType, Action<CRespDailyPlayInfo> successCallback = null, Action failCallback = null, uint rewardId = 0u)
		{
		}
	}
}
