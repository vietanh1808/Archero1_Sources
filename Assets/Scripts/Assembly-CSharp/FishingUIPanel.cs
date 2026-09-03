using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingUIPanel _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCountDown_003Ed__93(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private FitContentText fishingRodName;

	[SerializeField]
	private DxxText welfareBtnName;

	[SerializeField]
	private DxxText shopBtnName;

	[SerializeField]
	private DxxText rankingBtnName;

	[SerializeField]
	private DxxText bestiaryBtnName;

	[SerializeField]
	private FitContentText fishingDesc;

	[SerializeField]
	private ButtonCtrl rankingBtn;

	[SerializeField]
	private ButtonCtrl bestiaryBtn;

	[SerializeField]
	private ButtonCtrl fishingBtn;

	[SerializeField]
	private ButtonCtrl buyLureBtn;

	[SerializeField]
	private ButtonCtrl welfareBtn;

	[SerializeField]
	private ButtonCtrl shopBtn;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl infoBtn;

	[SerializeField]
	private ButtonCtrl leftClickBtn;

	[SerializeField]
	private ButtonCtrl rightClickBtn;

	[SerializeField]
	private Image sceneImg;

	[SerializeField]
	private Image shipImg;

	[SerializeField]
	private FishingInstrumentAni instrumentAni;

	[SerializeField]
	private FishingRodBloodAni rodBloodAni;

	[SerializeField]
	private FishingFishAni fishAni;

	[SerializeField]
	private DxxText lureCount;

	[SerializeField]
	private DxxText lureSelectCount;

	[SerializeField]
	private ButtonCtrl lureSelectBtn;

	[SerializeField]
	private Image selectLureCountBg;

	[SerializeField]
	private FishingAni fishingAni;

	[SerializeField]
	private FishingDialAni dialAni;

	[SerializeField]
	private RedNodeCtrl bestiaryRed;

	[SerializeField]
	private RedNodeCtrl welfareRed;

	[SerializeField]
	private RedNodeCtrl shopRed;

	[SerializeField]
	private GameObject fishingSceneUnlockObj;

	[SerializeField]
	private GameObject fishingSceneLockObj;

	[SerializeField]
	private DxxText fishingUnlockSceneName;

	[SerializeField]
	private DxxText fishingLockSceneName;

	[SerializeField]
	private DxxText fishingLockSceneDesc;

	[SerializeField]
	private Transform rodAniParent;

	[SerializeField]
	private FishingRodAni rodAniObj;

	[SerializeField]
	private FishingGuide fishingGuide;

	[SerializeField]
	private ButtonCtrl guideBtn;

	[SerializeField]
	private DxxText guideName;

	[SerializeField]
	private FishingSelectTipAni tipAni;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private Tween delayedCall;

	private FishingStatus fishingStatus;

	private FishingRodStatus fishingRodStatus;

	private FishingAniData fishingAniData;

	private FishingFishStatus fishStatus;

	private FishingFishAniStatus fishAniStatus;

	private float leftAniTime;

	private int aniIndex;

	private float fishDistance;

	private float tensionValue;

	private float mintensionValue;

	private float tensionSpeedValue;

	private float rodRiseSpeed;

	private float rodSpeed;

	private float failTotalTime;

	private int fishingSelectIndex;

	private uint startFishingTransID;

	private FishingRodAni rodAni;

	private int recordMaxUnlockAreaIndex;

	private static DelegateBridge __Hotfix0_get_FishingManager;

	private static DelegateBridge __Hotfix0_get_FishingData;

	private static DelegateBridge __Hotfix0_get_FishingSceneData;

	private static DelegateBridge __Hotfix0_get_FishingLureData;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_CreateRodAni;

	private static DelegateBridge __Hotfix0_ResetData;

	private static DelegateBridge __Hotfix0_SetOriginData;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshAni;

	private static DelegateBridge __Hotfix0_RefreshArrow;

	private static DelegateBridge __Hotfix0_RefreshScene;

	private static DelegateBridge __Hotfix0_RefreshRodSkin;

	private static DelegateBridge __Hotfix0_RefreshRod;

	private static DelegateBridge __Hotfix0_RefreshArea;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshDesc;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshSelectAreaAni;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge __Hotfix0_RequestRanking;

	private static DelegateBridge __Hotfix0_ClickRanking;

	private static DelegateBridge __Hotfix0_ClickBestiary;

	private static DelegateBridge __Hotfix0_ClickFishing;

	private static DelegateBridge __Hotfix0_ClickFishingDown;

	private static DelegateBridge __Hotfix0_ClickFishingUp;

	private static DelegateBridge __Hotfix0_ClickBuyLure;

	private static DelegateBridge __Hotfix0_CLickWelfare;

	private static DelegateBridge __Hotfix0_ClickShop;

	private static DelegateBridge __Hotfix0_ClickLureSelect;

	private static DelegateBridge __Hotfix0_ClickClose;

	private static DelegateBridge __Hotfix0_ClickInfo;

	private static DelegateBridge __Hotfix0_ClickGuide;

	private static DelegateBridge __Hotfix0_ClickLeft;

	private static DelegateBridge __Hotfix0_ClickRight;

	private static DelegateBridge __Hotfix0_RefreshSelectArea;

	private static DelegateBridge __Hotfix0_RequestFishingStartSelect;

	private static DelegateBridge __Hotfix0_RequestFishingSelect;

	private static DelegateBridge __Hotfix0_RequestFishingCastRod;

	private static DelegateBridge __Hotfix0_RequestFishingHolding;

	private static DelegateBridge __Hotfix0_RequestFishingStart;

	private static DelegateBridge __Hotfix0_RequestFishingHook;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_UpdateFishing;

	private static DelegateBridge __Hotfix0_UpdateFishingData;

	private static DelegateBridge __Hotfix0_UpdateFishingRodData;

	private static DelegateBridge __Hotfix0_UpdateFishingFishData;

	private static DelegateBridge __Hotfix0_CheckOver;

	private static DelegateBridge __Hotfix0_GetFishingFishAniStatus;

	private static DelegateBridge __Hotfix0_RequestFishingResult;

	private static DelegateBridge __Hotfix0_RequestFishing;

	private static DelegateBridge __Hotfix0_RequestCheckFishingStatus;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge __Hotfix0_CheckPlayGuide;

	private static DelegateBridge __Hotfix0_PlayGuide;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingManager FishingManager => null;

	private FishingData FishingData => null;

	private FishingSceneData FishingSceneData => null;

	private FishingLureData FishingLureData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void CreateRodAni()
	{
	}

	private void ResetData()
	{
	}

	private void SetOriginData(int fishID)
	{
	}

	private void Refresh()
	{
	}

	private void RefreshAni()
	{
	}

	private void RefreshArrow(int index)
	{
	}

	private void RefreshScene()
	{
	}

	private void RefreshRodSkin()
	{
	}

	private void RefreshRod()
	{
	}

	private void RefreshArea()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshDesc()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshSelectAreaAni()
	{
	}

	private void RefreshRed()
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__93))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void RequestRanking()
	{
	}

	private void ClickRanking()
	{
	}

	private void ClickBestiary()
	{
	}

	private void ClickFishing()
	{
	}

	private void ClickFishingDown()
	{
	}

	private void ClickFishingUp()
	{
	}

	private void ClickBuyLure()
	{
	}

	private void CLickWelfare()
	{
	}

	private void ClickShop()
	{
	}

	private void ClickLureSelect()
	{
	}

	private void ClickClose()
	{
	}

	private void ClickInfo()
	{
	}

	private void ClickGuide()
	{
	}

	private void ClickLeft()
	{
	}

	private void ClickRight()
	{
	}

	private void RefreshSelectArea(int selectAreaID, int nextIndex)
	{
	}

	private void RequestFishingStartSelect()
	{
	}

	private void RequestFishingSelect()
	{
	}

	private void RequestFishingCastRod()
	{
	}

	private void RequestFishingHolding()
	{
	}

	private void RequestFishingStart(int lureCount)
	{
	}

	private void RequestFishingHook()
	{
	}

	private void Update()
	{
	}

	private void UpdateFishing()
	{
	}

	private void UpdateFishingData()
	{
	}

	private void UpdateFishingRodData()
	{
	}

	private void UpdateFishingFishData()
	{
	}

	private void CheckOver()
	{
	}

	private FishingFishAniStatus GetFishingFishAniStatus(FishingFishStatus fishStatus)
	{
		return FishingFishAniStatus.None;
	}

	private void RequestFishingResult(FishingResult result, int index)
	{
	}

	private void RequestFishing(int index, Action<CRespGameFishing> success, Action failure)
	{
	}

	private void RequestCheckFishingStatus(int lureCount)
	{
	}

	private void Esc()
	{
	}

	private void CheckPlayGuide()
	{
	}

	private void PlayGuide()
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

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
