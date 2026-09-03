using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GamePlayActivityOne_CooperationPVP : GamePlayActivityOneCtrl
{
	[CompilerGenerated]
	private sealed class _003CCoundDown_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GamePlayActivityOne_CooperationPVP _003C_003E4__this;

		private long _003CendTime_003E5__2;

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
		public _003CCoundDown_003Ed__36(int _003C_003E1__state)
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

	[Header("匹配")]
	public PVPMatchBtnCtl[] matchbtns;

	public PVPMatchCtrl[] matchs;

	[Header("其他")]
	public DxxText textDebug;

	public DxxText textLastTime;

	public DxxText textScore;

	public DxxText textUnlock;

	public DxxText textUnlockCd;

	private CooperationData cooperatonData;

	private string mRoomId;

	public ButtonCtrl Button_Tip;

	public ButtonCtrl Button_Board;

	public ButtonCtrl Button_Report;

	[SerializeField]
	private GameObject _goPvp3ConditionTips;

	[SerializeField]
	private DxxText _textSuperDiamondTip1;

	[SerializeField]
	private DxxText _textSuperDiamondTip2;

	[SerializeField]
	private DxxText _textSuperDiamondTip3;

	private Coroutine m_Coroutine;

	public bool isActive;

	private bool IsLock => false;

	protected void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnUpdateCard(object obj)
	{
	}

	private void OnTipClick()
	{
	}

	protected override void RefreshData()
	{
	}

	protected override void onMaskShow(bool value)
	{
	}

	private void resetLastTime()
	{
	}

	private void CheckMatch()
	{
	}

	protected void OnClickCreateRoom()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void updateData()
	{
	}

	private void RefreshLastTimeText()
	{
	}

	private void ShowPVPMatchBtn()
	{
	}

	protected override void RefreshEndTime()
	{
	}

	protected override void RefreshStartTime()
	{
	}

	[IteratorStateMachine(typeof(_003CCoundDown_003Ed__36))]
	private IEnumerator CoundDown()
	{
		return null;
	}
}
