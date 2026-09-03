using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLua;

public class CampTimingGiftEntry : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRefreshCountDown_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CampTimingGiftEntry _003C_003E4__this;

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
		public _003CRefreshCountDown_003Ed__14(int _003C_003E1__state)
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
	private ButtonCtrl click;

	[SerializeField]
	private DxxText countDown;

	private TileInsPop tileIns;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private static DelegateBridge __Hotfix0_get_CampGiftManager;

	private static DelegateBridge __Hotfix0_get_CampTimingGiftData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_CloseTimer;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshContent;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampGiftManager CampGiftManager => null;

	private CampTimingGiftData CampTimingGiftData => null;

	public void Init(TileInsPop tile)
	{
	}

	public void Close()
	{
	}

	public void CloseTimer()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshContent()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshCountDown_003Ed__14))]
	private IEnumerator RefreshCountDown()
	{
		return null;
	}

	public void RefreshTime()
	{
	}
}
