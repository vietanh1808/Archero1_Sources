using System;
using Dxx.Net;
using GameProtocol;
using XLua;

namespace Activity
{
	public class ActivityExchangeData
	{
		public const int EXCHANGE_ITEM_ID = 33001;

		public const int EXCHANGE_ITEM_ID2 = 33002;

		public CRespActivityExchange exchangeData;

		private bool _redNodeCached;

		private bool _redNodeDirty;

		private float _redNodeCacheTime;

		private const float RED_NODE_CACHE_DURATION = 5f;

		private static DelegateBridge __Hotfix0_get_ItemCount;

		private static DelegateBridge __Hotfix0_get_ItemCount2;

		private static DelegateBridge __Hotfix0_get_DiamondCount;

		private static DelegateBridge __Hotfix0_get_EventExist;

		private static DelegateBridge __Hotfix0_get_EventEnd;

		private static DelegateBridge __Hotfix0_get_EventStart;

		private static DelegateBridge __Hotfix0_get_Style;

		private static DelegateBridge __Hotfix0_InvalidateRedNode;

		private static DelegateBridge __Hotfix0_get_RedNode;

		private static DelegateBridge __Hotfix0_ReqInfo;

		private static DelegateBridge __Hotfix0_OnReqInfoResponse;

		private static DelegateBridge __Hotfix0_GetData;

		private static DelegateBridge __Hotfix0_GetExchangeData;

		private static DelegateBridge __Hotfix0_ReqRedeem;

		private static DelegateBridge __Hotfix0_OnRedeemResponse;

		private static DelegateBridge __Hotfix0_GetEvent;

		private static DelegateBridge __Hotfix0_SortByPos;

		private static DelegateBridge _c__Hotfix0_ctor;

		public static int ItemCount => 0;

		public static int ItemCount2 => 0;

		public static long DiamondCount => 0L;

		public bool EventExist => false;

		public bool EventEnd => false;

		public bool EventStart => false;

		public int Style => 0;

		public bool RedNode => false;

		public void InvalidateRedNode()
		{
		}

		public void ReqInfo(Action<bool> callback = null)
		{
		}

		private void OnReqInfoResponse(NetResponse netResponse, Action<bool> callback = null)
		{
		}

		public CRespActivityExchange GetData()
		{
			return null;
		}

		public CActivityExchangeData GetExchangeData(int index)
		{
			return null;
		}

		public void ReqRedeem(uint id)
		{
		}

		private void OnRedeemResponse(NetResponse response)
		{
		}

		private ActivityMgr.Event GetEvent()
		{
			return ActivityMgr.Event.None_CheckIn;
		}

		public void SortByPos()
		{
		}
	}
}
