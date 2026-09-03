using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;
using UnityEngine;

public class MonopolyAchUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003COnGetReward_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolyAchUIPanel _003C_003E4__this;

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
		public _003COnGetReward_003Ed__15(int _003C_003E1__state)
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

	public DxxText maxRewardTex;

	public DxxText loopDescTex;

	public DxxText MaxBloodTex;

	public MonopolyAchRewardItem maxRewardItem;

	public MonopolyAchRewardItem loopRewardItem;

	public MonopolyAchItem copyItem;

	public RectTransform itemParent;

	public ButtonCtrl closeBtn;

	public RectTransform Mask;

	private List<MonopolyAchItem> items;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void ClosePanel()
	{
	}

	[IteratorStateMachine(typeof(_003COnGetReward_003Ed__15))]
	public IEnumerator OnGetReward(List<Drop_DropModel.DropData> list, bool isLast)
	{
		return null;
	}

	private void RefreshList()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void freshTime()
	{
	}
}
