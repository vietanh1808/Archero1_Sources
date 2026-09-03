using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Util;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class AdHarvestShortUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CReqHarvestData_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdHarvestShortUICtrl _003C_003E4__this;

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
		public _003CReqHarvestData_003Ed__38(int _003C_003E1__state)
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

	public UILineCtrl mTitle;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public DxxText Text_Description;

	public ScrollRectBase mScrollRect;

	public DxxText Text_Altar;

	public GameObject Panel_VIP;

	public DxxText Text_VipDesc;

	public GameObject Go_DiamondCard;

	public DxxText Text_CardDesc;

	private const int LineCount = 5;

	private const float WidthOne = 140f;

	private const float HeightOne = 140f;

	private GameObject _harvestitem;

	private LocalUnityObjctPool mPool;

	private SequencePool mSeqPool;

	private List<Drop_DropModel.DropData> mDataList;

	public const int reward_interval = 43200;

	private LoadSyncCtrl mLoadCtrl;

	private bool bCanReward;

	public GameObject RelicsValueObj;

	public DxxText Text_RelicsValue;

	private Coroutine m_Coroutine;

	public ButtonCtrl Button_Ad;

	public DxxText Text_Ad;

	public AdsController ads;

	public ButtonCtrl Button_key_Diamond;

	public GameObject Icon_Key;

	public GameObject Icon_Diamond;

	public DxxText Text_TipsUp;

	public DxxText Text_TipsDown;

	public DxxText Text_Key;

	public DxxText Text_Diamond;

	public DxxText Text_TimeLeft;

	private GameObject harvestitem => null;

	protected override void OnInit()
	{
	}

	private void GetRewards(bool bByAd = false)
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateBtns()
	{
	}

	private void InitUI()
	{
	}

	private void UpdateUI()
	{
	}

	public static bool CanGetReward()
	{
		return false;
	}

	public static bool CanGetReward_RedPoint()
	{
		return false;
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	[IteratorStateMachine(typeof(_003CReqHarvestData_003Ed__38))]
	private IEnumerator ReqHarvestData()
	{
		return null;
	}

	public void freshAdButton()
	{
	}

	private void onButtonAd()
	{
	}

	private void onGetAdReward()
	{
	}

	private void freshKey_DiamondButton()
	{
	}

	private void onButtonKey_Diamond()
	{
	}

	public static bool CanGetReward_RedPoint(bool isCheckAdPanelShow = false)
	{
		return false;
	}
}
