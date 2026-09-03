using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SkyScraperUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CPlayCountChange_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Text NumTex;

		public int num_2;

		private float _003Coffset_003E5__2;

		private float _003Cstep_003E5__3;

		private float _003Cresult_003E5__4;

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
		public _003CPlayCountChange_003Ed__57(int _003C_003E1__state)
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
	private sealed class _003CStartLongPressBtn_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkyScraperUIPanel _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private bool _003CisPlaySound_003E5__3;

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
		public _003CStartLongPressBtn_003Ed__60(int _003C_003E1__state)
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

	public DxxText titleTex;

	public DxxText timeTex;

	public DxxText previewBtnTex;

	public DxxText okBtnNumTex;

	public DxxText okBtnTex;

	public DxxText shopBtnTex;

	public DxxText getMatBtnTex;

	public DxxText addSpeedText;

	public DxxText matNumText;

	public DxxText shopMat1NumText;

	public DxxText shopMat2NumText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl BgBtn;

	public ButtonCtrl infoBtn;

	public ButtonCtrl okBtn;

	public ButtonCtrl quickBuyBtn;

	public ButtonCtrl previewBtn;

	public ButtonCtrl shopBtn;

	public ButtonCtrl getMatBtn;

	public Image btnMatIconImg;

	public Image matIconImg;

	public Image shopMat1IconImg;

	public Image shopMat2IconImg;

	public Image longPressImg;

	public Image btnImg;

	public GameObject speedCheckObj;

	public SkyScraperPreviewPanel scraperPreviewPanel;

	public SkyScraperGamePart skyScraperGamePart;

	public SkyScraperRewardsPart skyScraperRewardsPart;

	public RedNodeCtrl shopNode;

	public RedNodeCtrl getMatNode;

	public ButtonCtrl getRewardBtn;

	public DxxText getRewardText;

	public DxxText curLayerText;

	public static bool isPlaying;

	private bool isAuto;

	private bool isAddSpeeding;

	private long startAutoTime;

	private Coroutine LongPressCor;

	private TimeLineContainer timeLine;

	private float LongPressDra;

	private const string guideKey = "SkyScraperGuide";

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshUI()
	{
	}

	public void RefreshRed()
	{
	}

	private void OnInfoCallBack(bool obj)
	{
	}

	private void OnShopBuyCallBack(bool obj)
	{
	}

	private void OnReqGiftCallBack(bool obj)
	{
	}

	private void OnReqQuickBuyCallBack(bool obj)
	{
	}

	private void OnReqTaskCallBack(bool obj)
	{
	}

	private void OnReqAllRewardCallBack()
	{
	}

	private void OnReqEndAni()
	{
	}

	private void OnFlyAniEnd()
	{
	}

	private void OnNextBuilding()
	{
	}

	private void ClickGetReward()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	protected override void OnClose()
	{
	}

	private void RefreshMatNum(bool isAni = false)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayCountChange_003Ed__57))]
	public IEnumerator PlayCountChange(Text NumTex, int num_2)
	{
		return null;
	}

	private void OnStopAni()
	{
	}

	[IteratorStateMachine(typeof(_003CStartLongPressBtn_003Ed__60))]
	private IEnumerator StartLongPressBtn()
	{
		return null;
	}

	private void ClickOk()
	{
	}

	public void ClickAddSpeed()
	{
	}

	private void ClickGetMat()
	{
	}

	private void ClickShop()
	{
	}

	private void ClickPreview()
	{
	}

	private void ClickQuickBuy()
	{
	}

	private void ClickInfo()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void freshTime()
	{
	}

	private void ClosePanel()
	{
	}

	public void StartGuide(int index)
	{
	}
}
