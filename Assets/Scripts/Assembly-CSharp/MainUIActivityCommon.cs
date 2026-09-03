using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Activity;
using Dxx.Util;
using UnityEngine;
using XLua;

public class MainUIActivityCommon : MainUIButtonBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIActivityCommon _003C_003E4__this;

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
		public _003CCountDown_003Ed__42(int _003C_003E1__state)
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
	private GameObject child;

	[SerializeField]
	private RedNodeCtrl mRedCtrl;

	[SerializeField]
	private ButtonCtrl Button_Reward;

	[SerializeField]
	private DxxText Text_Time;

	[SerializeField]
	private GameObjectSwitcher switcher;

	[SerializeField]
	private ParticleSystem rotEff;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private CanvasGroup ImgCanvas;

	private float UI_Alpha;

	private float alphaSpeed;

	private float startRotTotal;

	private float endRotTotal;

	private float rotCount;

	private SequencePool mSeqPool;

	private bool isExecuting;

	private Coroutine m_Coroutine;

	private Tab curTab;

	private HashSet<Tab> requestingEvents;

	private WaitForSeconds m_wait;

	private float t;

	private bool isRot;

	private float timer;

	private static DelegateBridge __Hotfix0_get_TurntableOn;

	private static DelegateBridge __Hotfix0_get_ExchangeOn;

	private static DelegateBridge __Hotfix0_get_CustomOn;

	private static DelegateBridge __Hotfix0_get_TreasureOn;

	private static DelegateBridge __Hotfix0_get_ConsumptionOn;

	private static DelegateBridge __Hotfix0_get_BingoOn;

	private static DelegateBridge __Hotfix0_get_ChainGiftOn;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnClickBtn;

	private static DelegateBridge __Hotfix0_ShowActivityUI;

	private static DelegateBridge __Hotfix0_OnRequestFinished;

	private static DelegateBridge __Hotfix0_TryOpen;

	private static DelegateBridge __Hotfix0_CanShow;

	private static DelegateBridge __Hotfix0_Show;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge __Hotfix0_IsShow;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge __Hotfix0_GetPriority;

	private static DelegateBridge __Hotfix0_GetTransform;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_SetRot;

	private static DelegateBridge __Hotfix0_GetOpenTime;

	private static DelegateBridge __Hotfix0_isRed;

	private static DelegateBridge _c__Hotfix0_ctor;

	private bool TurntableOn => false;

	private bool ExchangeOn => false;

	private bool CustomOn => false;

	private bool TreasureOn => false;

	private bool ConsumptionOn => false;

	private bool BingoOn => false;

	private bool ChainGiftOn => false;

	private void Awake()
	{
	}

	private void OnClickBtn()
	{
	}

	private void ShowActivityUI()
	{
	}

	private void OnRequestFinished(Tab tab)
	{
	}

	private void TryOpen()
	{
	}

	private bool CanShow()
	{
		return false;
	}

	private void Show(bool show)
	{
	}

	public new void UpdateUI()
	{
	}

	public override bool IsShow()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__42))]
	private IEnumerator CountDown()
	{
		return null;
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	protected override void OnClose()
	{
	}

	private void Update()
	{
	}

	private void SetRot(bool value)
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	public override bool isRed()
	{
		return false;
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private bool _003C_003ExLuaBaseProxy_isRed()
	{
		return false;
	}
}
