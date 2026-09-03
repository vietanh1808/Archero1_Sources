using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SailingTreasureMapUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003COnUpdate_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingTreasureMapUICtrl _003C_003E4__this;

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
		public _003COnUpdate_003Ed__17(int _003C_003E1__state)
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
	private SailingTreasureMapRewardUICtrl _sailingTreasureMapRewardUI;

	[SerializeField]
	private SailingTreasureMapUnlockUICtrl _sailingTreasureMapUnlockUI;

	[SerializeField]
	private SailingTreasureMapProgressCtrl[] _targets;

	[SerializeField]
	private DxxText _textCloseTips;

	[SerializeField]
	private Canvas _subCanvas;

	[SerializeField]
	private Image _unlockImgTarget;

	[SerializeField]
	private Image _imgMask;

	[SerializeField]
	private ButtonCtrl _btnInfo;

	[SerializeField]
	private DxxText _textInfo;

	[SerializeField]
	private ButtonCtrl _btnClose;

	private Coroutine _coroutine;

	private WaitForSeconds _wait;

	public bool IsGuiding => false;

	private int Minute => 0;

	private int Distance => 0;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	[IteratorStateMachine(typeof(_003COnUpdate_003Ed__17))]
	private IEnumerator OnUpdate()
	{
		return null;
	}

	private void CheckShowUnlockEventUI(int minute, int distance)
	{
	}

	private void CheckNextUnlockEventUI(int id)
	{
	}

	private void UpdateUI(int distance, int minute)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnClickTarget(ShipBattle_TreasureMap data, bool unlock)
	{
	}

	public void CloseUI()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
