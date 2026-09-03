using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class GamePlayActivityUICtrl : MediatorCtrlBase
{
	public enum ReqState
	{
		eReqing = 0,
		eReqSuccess = 1,
		eReqFail = 2
	}

	[CompilerGenerated]
	private sealed class _003CWaitClose_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GamePlayActivityUICtrl _003C_003E4__this;

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
		public _003CWaitClose_003Ed__34(int _003C_003E1__state)
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

	public static bool IfChangeStateReqInfo;

	private bool ifBeginChangeStateReq;

	public static float ChangeStateReqTime;

	private const float ELEMENT_DISTANCE = 20f;

	public RectTransform CurrentWindow;

	public RectTransform contentParent;

	public DxxText textEmpty;

	public MainUIScrollRectInsideCtrl mInsideCtrl;

	public GameObject LoadingUI;

	public GameObject WarningUI;

	public Animator LoadingAnim;

	public DOTweenAnimation WarningAnim;

	public DxxText LoadingText;

	public DxxText WarningText;

	private List<GamePlayActivityOneCtrl> activityList;

	private Dictionary<int, string> copyItemDic;

	private Dictionary<int, Queue<GamePlayActivityOneCtrl>> cacheDic;

	private const float TIME_INTERVAL = 30f;

	private const float NET_INTERVAL = 60f;

	private float time_tickTime;

	private float net_tickTime;

	private bool isDaily130Visible;

	private static bool ifFirstReq;

	private int reqDataFailTimes;

	private bool ifOpen;

	private SequencePool reqPool;

	private Dictionary<int, Func<bool>> mActivityOpen;

	private Coroutine closeIEnumerator;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnReqSuccess()
	{
	}

	private void OnReqFail()
	{
	}

	protected override void OnClose()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitClose_003Ed__34))]
	private IEnumerator WaitClose()
	{
		return null;
	}

	private void Update()
	{
	}

	private void CloseNewPlay120()
	{
	}

	private void RefreshList()
	{
	}

	private bool ShouldShowDaily130()
	{
		return false;
	}

	private GamePlayActivityOneCtrl GetActivityObj(int type)
	{
		return null;
	}

	private void Recycle(GamePlayActivityOneCtrl ctrl)
	{
	}

	private void DoWithReq(ReqState state)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnDeInit()
	{
	}
}
