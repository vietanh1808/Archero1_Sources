using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;
using XLua;

namespace Activity
{
	public class TreasurePanel : PanelBase
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtCountdown;

		[SerializeField]
		private DxxText txtDesc;

		[SerializeField]
		private DxxText txtBtnCount;

		[SerializeField]
		private DxxText txtTenBtnCount;

		[SerializeField]
		private DxxText txtTitleTreasure;

		[SerializeField]
		private DxxText txtTitleNormal;

		[SerializeField]
		private DxxText txtBtnBuy;

		[SerializeField]
		private DxxText txtBtnProgress;

		[SerializeField]
		private DxxText txtQuota;

		[SerializeField]
		private DxxText txtRemind;

		[SerializeField]
		private DxxImage imgBar;

		[SerializeField]
		private DxxImage imgIconBuy;

		[SerializeField]
		private DxxImage imgIconBuyTen;

		[SerializeField]
		private DxxImage imgIconPoint;

		[SerializeField]
		private DxxImage imgIconBtn;

		[SerializeField]
		private DxxImage imgBgItems;

		[FormerlySerializedAs("imgBg")]
		[SerializeField]
		private DxxImage imgBgPage;

		[FormerlySerializedAs("imgBg2")]
		[SerializeField]
		private DxxImage imgBgContent;

		[SerializeField]
		private ButtonCtrl btnInfo;

		[SerializeField]
		private ButtonCtrl btnDraw;

		[SerializeField]
		private ButtonCtrl btnDrawTen;

		[SerializeField]
		private ButtonCtrl btnSelect;

		[SerializeField]
		private ButtonCtrl btnBuyCoin;

		[SerializeField]
		private ButtonCtrl btnProgress;

		[SerializeField]
		private RectTransform title;

		[SerializeField]
		private TreasureCoinPanel coinPanel;

		[SerializeField]
		private TreasureSelectPanel selectPanel;

		[SerializeField]
		private TreasureProgressPop progressPop;

		[SerializeField]
		private TreasureSelectItem template;

		[SerializeField]
		private Transform contentRoot;

		[SerializeField]
		private GameObject goAdd;

		[SerializeField]
		private GameObject goChange;

		[SerializeField]
		private PropOneEquip prop;

		[SerializeField]
		private RedNodeCtrl[] redNodes;

		[SerializeField]
		private TreasureEventStyle[] styles;

		[SerializeField]
		private DxxText guaranteeText;

		private LocalUnityObjctPool pool;

		private bool isTen;

		private TreasureEventStyle curStyle;

		private float time;

		private static DelegateBridge __Hotfix0_get_curEvent;

		private static DelegateBridge __Hotfix0_get_Count;

		private static DelegateBridge __Hotfix0_get_ChanceCount;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_PreDraw;

		private static DelegateBridge __Hotfix0_Draw;

		private static DelegateBridge __Hotfix0_OpenSelectPanel;

		private static DelegateBridge __Hotfix0_OpenBuyCoinPanel;

		private static DelegateBridge __Hotfix0_OpenProgressPanel;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_RefreshTime;

		private static DelegateBridge __Hotfix0_RefreshRedNodes;

		private static DelegateBridge __Hotfix0_Update;

		private static DelegateBridge __Hotfix0_SetStyle;

		private static DelegateBridge __Hotfix0_OnDisable;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge _c__Hotfix0_ctor;

		private ActivityMgr.Event curEvent => ActivityMgr.Event.None_CheckIn;

		private int Count => 0;

		private bool ChanceCount => false;

		private void Awake()
		{
		}

		public override void Init(IActivityUI ctrl)
		{
		}

		public override void Open()
		{
		}

		private void PreDraw()
		{
		}

		private void Draw()
		{
		}

		private void OpenSelectPanel()
		{
		}

		private void OpenBuyCoinPanel()
		{
		}

		private void OpenProgressPanel()
		{
		}

		public override void Refresh()
		{
		}

		private void RefreshTime()
		{
		}

		private void RefreshRedNodes()
		{
		}

		private void Update()
		{
		}

		private void SetStyle()
		{
		}

		private void OnDisable()
		{
		}

		public override void OnHandleNotification(INotification notification)
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

		private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
		{
		}
	}
}
