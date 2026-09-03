using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GuildActivityTabUICtrl : GuildPanelBase
{
	[CompilerGenerated]
	private sealed class _003CTick_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GuildActivityTabUICtrl _003C_003E4__this;

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
		public _003CTick_003Ed__11(int _003C_003E1__state)
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
	private GuildActivityStageInfinity infinity;

	private long minGuildEndTime;

	private long minDailyEndTime;

	public GameObject BG;

	private WaitForSeconds _wait;

	private void Awake()
	{
	}

	private void UpdateItem(int index, GuildActivityStageItem item)
	{
	}

	public override void onLanguageChanged()
	{
	}

	public override void showPanel()
	{
	}

	public override void hidePanel()
	{
	}

	private void SetActivities()
	{
	}

	[IteratorStateMachine(typeof(_003CTick_003Ed__11))]
	private IEnumerator Tick()
	{
		return null;
	}

	private void OnGuildActivityChange(object obj)
	{
	}

	public void SetInfinity()
	{
	}

	public void RefreshInfinity()
	{
	}
}
