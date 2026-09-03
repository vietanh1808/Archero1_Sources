using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

public class ShopOneThemeBox : ShopOneBase
{
	[CompilerGenerated]
	private sealed class _003CUpdateTime_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopOneThemeBox _003C_003E4__this;

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
		public _003CUpdateTime_003Ed__10(int _003C_003E1__state)
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

	public Text Title;

	public ShopItemThemeBox[] Items;

	public ThemeBoxManager Manager;

	public CountDownCtrl TimeShow;

	private bool IfNextDay;

	protected override void OnInit()
	{
	}

	protected override void OnDeinit()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void UpdateNet()
	{
	}

	public override void UpdateUI()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateTime_003Ed__10))]
	private IEnumerator UpdateTime()
	{
		return null;
	}
}
