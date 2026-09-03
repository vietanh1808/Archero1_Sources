using System;
using System.Collections.Generic;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

namespace Activity.Lattice
{
	public class LatticePanel : PanelBase
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtDesc;

		[SerializeField]
		private DxxText txtTimeCountDown;

		[SerializeField]
		private DxxText txtTimeCountDown2;

		[SerializeField]
		private DxxText txtTitleLevel;

		[SerializeField]
		private DxxText txtTitleGift;

		[SerializeField]
		private DxxText txtTitleRedeem;

		[SerializeField]
		private DxxText txtScoreCount;

		[SerializeField]
		private DxxText txtKeyCount;

		[SerializeField]
		private DxxText txtBtnAuto;

		[SerializeField]
		private DxxText txtBtnNext;

		[SerializeField]
		private ButtonCtrl btnGift;

		[SerializeField]
		private ButtonCtrl btnRedeem;

		[SerializeField]
		private ButtonCtrl btnAuto;

		[SerializeField]
		private RectTransform rtIconScore;

		[SerializeField]
		private RectTransform rtIconKey;

		public GameObject Red_Gift;

		public GameObject Red_Exch;

		[FormerlySerializedAs("btnBuyKey")]
		[SerializeField]
		private ButtonCtrl btnGetKey;

		[SerializeField]
		private ButtonCtrl btnInfo;

		[SerializeField]
		private ButtonCtrl btnNext;

		[SerializeField]
		private ButtonCtrl btnSelect;

		[SerializeField]
		private RectTransform rtBrickRoot;

		[SerializeField]
		private RewardPreviewItem[] previewItems;

		[SerializeField]
		private GameObject goReselect;

		[SerializeField]
		private List<LatticeItem> items;

		[SerializeField]
		private LatticeItem template;

		[SerializeField]
		private RewardPanel panelReward;

		[FormerlySerializedAs("panelWithToggleConfirm")]
		[FormerlySerializedAs("panelConfirm")]
		[SerializeField]
		private ConfirmPanelWithToggle panelConfirmWithToggle;

		[SerializeField]
		private KeyBuyPanel panelKeyBuy;

		[SerializeField]
		private ConfirmPanel panelConfirm;

		[Header("DOTween Params")]
		[SerializeField]
		private float shuffleDelay;

		[SerializeField]
		private float randomDelay;

		[SerializeField]
		private float durationGather;

		[SerializeField]
		private float durationSpread;

		[SerializeField]
		private float durationStay;

		[SerializeField]
		private GameObject goUseKey;

		private LocalUnityObjctPool pool;

		[SerializeField]
		private Sprite[] sprites;

		[SerializeField]
		private DxxImage imgKv;

		[SerializeField]
		private Toggle toggle_SkipAni;

		[SerializeField]
		private DxxText text_SkipAni;

		[SerializeField]
		private GameObject go_Mask;

		private int countHorizontal;

		private float halfHorizontal;

		private float halfVertical;

		private float edge;

		private Vector3 latticeScale;

		public bool isAutoFlipping;

		[SerializeField]
		private float shakeDuration;

		[SerializeField]
		private float shakeStrength;

		[SerializeField]
		private float shakeVibrato;

		private float timer;

		private static DelegateBridge __Hotfix0_get_style;

		private static DelegateBridge __Hotfix0_get_scorePos;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_OpenSelect;

		private static DelegateBridge __Hotfix0_OnBtnGetKeyClick;

		private static DelegateBridge __Hotfix0_OnBtnAutoClick;

		private static DelegateBridge __Hotfix0_ReqAuto;

		private static DelegateBridge __Hotfix0_OnBtnNextClick;

		private static DelegateBridge __Hotfix0_OnBtnInfoClick;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_Shuffle;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_RefreshLattices;

		private static DelegateBridge __Hotfix0_SetItem;

		private static DelegateBridge __Hotfix0_GetLatticePos;

		private static DelegateBridge __Hotfix0_CalcLatticeGeometry;

		private static DelegateBridge __Hotfix0_RefreshTextsDynamic;

		private static DelegateBridge __Hotfix0_SetTime;

		private static DelegateBridge __Hotfix0_freshRedPoint;

		private static DelegateBridge __Hotfix0_RefreshPreview;

		private static DelegateBridge __Hotfix0_RefreshButtons;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge __Hotfix0_Shake;

		private static DelegateBridge __Hotfix0_Update;

		private static DelegateBridge __Hotfix0_OpenConfirm;

		private static DelegateBridge __Hotfix0_UseKey;

		private static DelegateBridge _c__Hotfix0_ctor;

		private int style => 0;

		public Vector3 scorePos => default;

		public override void Init(IActivityUI ctrl)
		{
		}

		public void OpenSelect()
		{
		}

		private void OnBtnGetKeyClick()
		{
		}

		private void OnBtnAutoClick()
		{
		}

		private void ReqAuto()
		{
		}

		private void OnBtnNextClick()
		{
		}

		private void OnBtnInfoClick()
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		private void Shuffle(bool fromNextLevel)
		{
		}

		public override void Refresh()
		{
		}

		private void RefreshLattices()
		{
		}

		private void SetItem(int i)
		{
		}

		private Vector2 GetLatticePos(int index)
		{
			return default;
		}

		private void CalcLatticeGeometry()
		{
		}

		private void RefreshTextsDynamic()
		{
		}

		private void SetTime()
		{
		}

		private void freshRedPoint()
		{
		}

		private void RefreshPreview()
		{
		}

		private void RefreshButtons()
		{
		}

		public override void OnLanguageChange()
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		public Sequence Shake()
		{
			return null;
		}

		private void Update()
		{
		}

		public void OpenConfirm(Action onConfirm, Action onCancel)
		{
		}

		public void UseKey(bool realKeyCount, int allCount = -1)
		{
		}

		private void _003C_003ExLuaBaseProxy_Init(IActivityUI P0)
		{
		}

		private void _003C_003ExLuaBaseProxy_Open()
		{
		}

		private void _003C_003ExLuaBaseProxy_Close()
		{
		}

		private void _003C_003ExLuaBaseProxy_Refresh()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnLanguageChange()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
		{
		}
	}
}
