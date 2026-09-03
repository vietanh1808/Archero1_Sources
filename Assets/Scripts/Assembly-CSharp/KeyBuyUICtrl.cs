using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class KeyBuyUICtrl : MediatorCtrlBase, AdsRequestHelper.AdsCallback
{
	public class KeyData
	{
		public int showCurrency;
	}

	[CompilerGenerated]
	private sealed class _003CUpdateCountdown_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KeyBuyUICtrl _003C_003E4__this;

		private long _003CtodayEnd_003E5__2;

		private long _003Ccurrent_003E5__3;

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
		public _003CUpdateCountdown_003Ed__51(int _003C_003E1__state)
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

	private static KeyBuySource mSource;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_DiamondCount;

	public DxxText Text_AdCount;

	public DxxText Text_AdLast;

	public DxxText Text_AdGet;

	public DxxText Text_BPFree;

	public Image Image_Ad;

	public GameObject freeparent;

	public GameObject notfreeparent;

	public DxxText Text_NotFreeCount;

	public GoldTextCtrl mAdCtrl;

	public GoldTextCtrl mDiamondCtrl;

	public GoldTextCtrl mNotFreeDiamondCtrl;

	public ButtonCtrl Button_Buy;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public ButtonCtrl Button_Ad;

	public ButtonCtrl Button_BuyNotFree;

	public ButtonCtrl Button_BPFree;

	public CountDownCtrl[] countDownCtrls;

	private float Text_AdGetX;

	private int KeyCount;

	private int adCount;

	private long needdiamond;

	private bool bAdReward;

	private bool bOpened;

	private Coroutine routine;

	public KeyData keyData;

	public static void SetSource(KeyBuySource source)
	{
	}

	public static KeyBuySource GetSource()
	{
		return KeyBuySource.EMAIN_BATTLE;
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void update_ad_count()
	{
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

	private void onRewardWrapper(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	private void onRewardInternal(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateCountdown_003Ed__51))]
	private IEnumerator UpdateCountdown()
	{
		return null;
	}
}
