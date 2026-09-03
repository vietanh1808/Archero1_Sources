using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity
{
	public class ActivityBPPanel : PanelBase
	{
		[SerializeField]
		private ButtonCtrl btnOpenBuy;

		[SerializeField]
		private ButtonCtrl btnOpenBuyPremium;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtTitleCountDown;

		[SerializeField]
		private DxxText txtTitlePaid;

		[SerializeField]
		private DxxText txtTitlePaidPremium;

		[SerializeField]
		private DxxText txtTitleFree;

		[SerializeField]
		private DxxText txtBtnBuy;

		[SerializeField]
		private DxxText txtBtnBuyPremium;

		[SerializeField]
		private DxxText txtNextLevel;

		[SerializeField]
		private DxxText txtLevelMax;

		[SerializeField]
		private DxxText txtProgress;

		[SerializeField]
		private DxxImage imgIconFree;

		[SerializeField]
		private DxxImage imgIconBp;

		[SerializeField]
		private DxxImage imgIconBpBig;

		[SerializeField]
		private CountDownCtrl countDownCtrl;

		[SerializeField]
		private RectTransform rtContent;

		[SerializeField]
		private RectTransform rtProgressBar;

		[SerializeField]
		private RectTransform rtLevelMask;

		[SerializeField]
		private ActivityBattlePassReward template;

		[SerializeField]
		private ActivityBPDetailPanel detailPanel;

		[SerializeField]
		private BattlePassChestInformation chestInfo;

		[SerializeField]
		private GameObject goIconNext;

		[SerializeField]
		private ActivityBpStyle[] styles;

		private ActivityBpStyle curStyle;

		private List<ActivityBattlePassReward> list;

		private LocalUnityObjctPool pool;

		private int itemCount;

		private float time;

		private static DelegateBridge __Hotfix0_get_curEvent;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_Update;

		private static DelegateBridge __Hotfix0_RefreshCountDown;

		private static DelegateBridge __Hotfix0_RefreshLanguage;

		private static DelegateBridge __Hotfix0_RefreshListItemsOnly;

		private static DelegateBridge __Hotfix0_RefreshList;

		private static DelegateBridge __Hotfix0_SetMaskPos;

		private static DelegateBridge __Hotfix0_SetStyle;

		private static DelegateBridge __Hotfix0_OnDisable;

		private static DelegateBridge _c__Hotfix0_ctor;

		private ActivityMgr.Event curEvent => ActivityMgr.Event.None_CheckIn;

		public override void Init(IActivityUI ctrl)
		{
		}

		public override void Open()
		{
		}

		public override void Refresh()
		{
		}

		private void Update()
		{
		}

		private void RefreshCountDown()
		{
		}

		private void RefreshLanguage()
		{
		}

		public void RefreshListItemsOnly()
		{
		}

		private void RefreshList()
		{
		}

		private void SetMaskPos(ActivityBattlePassReward item)
		{
		}

		private void SetStyle()
		{
		}

		private void OnDisable()
		{
		}

		private void _003C_003ExLuaBaseProxy_Init(IActivityUI P0)
		{
		}

		private void _003C_003ExLuaBaseProxy_Open()
		{
		}

		private void _003C_003ExLuaBaseProxy_Refresh()
		{
		}
	}
}
