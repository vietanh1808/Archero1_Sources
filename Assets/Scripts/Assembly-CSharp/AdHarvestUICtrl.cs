using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Util;
using GameProtocol;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class AdHarvestUICtrl : MediatorCtrlBase, AdsRequestHelper.AdsCallback
{
	[CompilerGenerated]
	private sealed class _003CReqHarvestData_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdHarvestUICtrl _003C_003E4__this;

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
		public _003CReqHarvestData_003Ed__50(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CUpdateCD_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdHarvestUICtrl _003C_003E4__this;

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
		public _003CUpdateCD_003Ed__53(int _003C_003E1__state)
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

	public UILineCtrl mTitleCtrl;

	public DxxText Text_Gold;

	public DxxText Text_Exp;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public UILineCtrl mUILineCtrl;

	public DxxText Text_reward1;

	public DxxText Text_reward2;

	public ButtonCtrl Button_Harvest;

	public ScrollRectBase mScrollRect;

	public GameObject Image_Ad;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public RectTransform Image_BG;

	public RectTransform Rect_fg;

	public ButtonCtrl Button_Desc;

	public UILineCtrl mTitleBoost;

	public DxxText Text_QuickGet;

	public ButtonCtrl Button_QuickGet;

	public AdHarvestBoost mBoostCtrl;

	public DxxText Text_PageTitle;

	public RedNodeCtrl mRedCtrl;

	public RedNodeCtrl videoRedCtrl;

	private RectTransform RectImage_Ad;

	private RectTransform RectButton_Harvest;

	private GameObject Get_Harvest;

	private const int LineCount = 5;

	private const float WidthOne = 140f;

	private const float HeightOne = 140f;

	private const float ButtonBGWidth = 300f;

	private const float ButtonWidth = 330f;

	private GameObject battlRectRT;

	private GameObject _harvestitem;

	private LocalUnityObjctPool mPool;

	private SequencePool mSeqPool;

	private List<Drop_DropModel.DropData> mDataList;

	private string adharvest_time;

	private int reward_interval;

	private float scrollwidth;

	private LoadSyncCtrl mLoadCtrl;

	private bool bCanReward;

	private bool m_bInitRewardUIFlag;

	protected bool multiTouchBackup;

	private Coroutine m_Coroutine;

	private Coroutine m_Coroutine2;

	private GameObject harvestitem => null;

	protected override void OnInit()
	{
	}

	private void InitRT()
	{
	}

	protected override void OnOpen()
	{
	}

	[IteratorStateMachine(typeof(_003CReqHarvestData_003Ed__50))]
	private IEnumerator ReqHarvestData()
	{
		return null;
	}

	private void InitUI()
	{
	}

	private void UpdateUI()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateCD_003Ed__53))]
	private IEnumerator UpdateCD()
	{
		return null;
	}

	private void RefRedNode()
	{
	}

	private void android_escape()
	{
	}

	public void GetHarvestAd()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnDestroy()
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

	public void onRequest(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onLoad(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onFail(AdsRequestHelper.AdsDriver sender, string msg)
	{
	}

	public void onOpen(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClose(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClick(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onReward(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	private void ShowReward(CRespItemPacket packetdata, List<Drop_DropModel.DropData> list)
	{
	}
}
