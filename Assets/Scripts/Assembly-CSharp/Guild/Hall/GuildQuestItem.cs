using System;
using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Guild.Hall
{
	public class GuildQuestItem : GuildBaseMono
	{
		public enum ValueStringType
		{
			none = 0,
			monsterName = 1,
			heroName = 2,
			dailyName = 3,
			onlyNumber = 4
		}

		public enum GoType
		{
			none = 0,
			mainUI = 110,
			dailyUI = 150,
			farmUI = 220,
			gotoTheMosterScene = 211,
			guildDonate = 311,
			guildShop = 330,
			guildHelp = 321
		}

		[Header("任务信息")]
		public Image icon;

		public Text contentText;

		public Text dimValueText;

		public Text sorValueText;

		public Image sorIcon;

		public Image xpIcon;

		[Header("NormalState")]
		public Transform normalState;

		public ButtonCtrl refBtn;

		public Text refBtnText;

		public ButtonCtrl goBtn;

		public Text goBtnText;

		public ButtonCtrl dimRefBtn;

		public Text dimRefBtnText;

		[Header("LockState")]
		public Transform lockState;

		public Text lockText;

		[Header("gotState")]
		public Transform gotState;

		public Text gotText;

		[Header("gotState")]
		public Transform canGetState;

		public ButtonCtrl getBtn;

		public Text canGetBtnText;

		private GuildQuestInfo questInfo;

		private int index;

		private Guild_TaskPool taskCfg;

		private DiamondCostList diamondRefCost;

		private static bool sending;

		private static DelegateBridge __Hotfix0_OnInit;

		private static DelegateBridge __Hotfix0_OnOpen;

		private static DelegateBridge __Hotfix0_OnClose;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_Show;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_RefLanguageText;

		private static DelegateBridge __Hotfix0_RestUI;

		private static DelegateBridge __Hotfix0_RestBtnState;

		private static DelegateBridge __Hotfix0_RestNormalState;

		private static DelegateBridge __Hotfix0_SetInfoAlpha;

		private static DelegateBridge __Hotfix0_GetGemRefCount;

		private static DelegateBridge __Hotfix0_GetStringByAgrsType;

		private static DelegateBridge __Hotfix0_OnRefBtnClick;

		private static DelegateBridge __Hotfix0_OnGoBtnClick;

		private static DelegateBridge __Hotfix0_OnGetBtnClick;

		private static DelegateBridge __Hotfix0_SendRequest;

		private static DelegateBridge __Hotfix0_OnRefCountChanged;

		private static DelegateBridge __Hotfix0_OnGuildFakeDataChanged;

		private static DelegateBridge __Hotfix0_UpdateCount;

		private static DelegateBridge __Hotfix0_SendTGPPoint;

		private static DelegateBridge _c__Hotfix0_ctor;

		public override void OnInit()
		{
		}

		public override void OnOpen()
		{
		}

		public override void OnClose()
		{
		}

		public override void OnLanguageChange()
		{
		}

		public void Show(bool show)
		{
		}

		public void Close()
		{
		}

		public void SetData(GuildQuestInfo qInfo, int pIndex)
		{
		}

		private void RefLanguageText()
		{
		}

		private void RestUI()
		{
		}

		private void RestBtnState()
		{
		}

		private void RestNormalState(bool show)
		{
		}

		private void SetInfoAlpha(float alpha)
		{
		}

		private int GetGemRefCount()
		{
			return 0;
		}

		public static string GetStringByAgrsType(int type, int value)
		{
			return null;
		}

		private void OnRefBtnClick()
		{
		}

		private void OnGoBtnClick()
		{
		}

		private void OnGetBtnClick()
		{
		}

		private static bool SendRequest(int type, int pIndex, Action<CRespGuildTaskInfo> onComplete, Action<string> onError)
		{
			return false;
		}

		private void OnRefCountChanged(object data)
		{
		}

		private void OnGuildFakeDataChanged(object data)
		{
		}

		private void UpdateCount(int addValue)
		{
		}

		private void SendTGPPoint(int code, string step, string reason, int source, int gems, int score, int xp, int lastid, int nextid)
		{
		}

		private void _003C_003ExLuaBaseProxy_OnInit()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnOpen()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnClose()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnLanguageChange()
		{
		}
	}
}
