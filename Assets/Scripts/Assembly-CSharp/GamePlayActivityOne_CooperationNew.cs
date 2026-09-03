using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GamePlayActivityOne_CooperationNew : GamePlayActivityOneCtrl
{
	[CompilerGenerated]
	private sealed class _003CCoundDown_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GamePlayActivityOne_CooperationNew _003C_003E4__this;

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
		public _003CCoundDown_003Ed__33(int _003C_003E1__state)
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

	[Header("建立房间")]
	public ButtonCtrl buttonCreateRoom;

	public DxxText textCreateRoom;

	public GameObject buttonCreateMask;

	[Header("匹配")]
	public ButtonCtrl buttonMatch;

	public DxxText textMatch;

	public GameObject buttonMatchMask;

	[Header("其他")]
	public DxxText textDebug;

	public DxxText textLastTime;

	[SerializeField]
	private DxxText textUnlock;

	[SerializeField]
	private DxxText textUnlockCd;

	private CooperationData cooperatonData;

	private string mRoomId;

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

	protected override void onMaskShow(bool value)
	{
	}

	protected override void RefreshData()
	{
	}

	private void ShowMatchBtn()
	{
	}

	private bool CheatPlayDaily()
	{
		return false;
	}

	private void CheckMatch()
	{
	}

	protected void OnClickMatch()
	{
	}

	protected void OnClickCreateRoom()
	{
	}

	private void CheckLastRoom()
	{
	}

	private void CreateRoom()
	{
	}

	private void OnClickJoinIn()
	{
	}

	private void OpenJoinIn()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshLastTimeText()
	{
	}

	private void RefreshDebugInfo()
	{
	}

	[IteratorStateMachine(typeof(_003CCoundDown_003Ed__33))]
	private IEnumerator CoundDown()
	{
		return null;
	}
}
