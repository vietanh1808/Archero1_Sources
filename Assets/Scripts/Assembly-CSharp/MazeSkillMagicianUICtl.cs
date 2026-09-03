using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;
using UnityEngine;

public class MazeSkillMagicianUICtl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CStopAni_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MazeSkillMagicianUICtl _003C_003E4__this;

		private int _003Ci_003E5__2;

		private MazeSkillMagicianItemCtl _003Citem_003E5__3;

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
		public _003CStopAni_003Ed__23(int _003C_003E1__state)
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

	public DxxText texttitle;

	public DxxText npctalk;

	public DxxText uicontext;

	public DxxText info_Money;

	public ButtonCtrl buttonBack;

	public Animator itemAnimator;

	public GameObject canClick;

	public int itemCount;

	public GameObject itemTemp;

	public Transform itemsParent;

	[SerializeField]
	private ButtonCtrl jumpAniBtn;

	[SerializeField]
	private DxxText jumpAniTip;

	protected MazeSkillMagicianItemCtl[] skills;

	private MazeSkillMagicianProxy.Transfer transfer;

	private Coroutine curCoroutine;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void SetMoney(string pToken)
	{
	}

	private bool CheckCanAddSkill(List<int> skillIconIds, int curskillid)
	{
		return false;
	}

	private void RestUI()
	{
	}

	private void RefUIData()
	{
	}

	[IteratorStateMachine(typeof(_003CStopAni_003Ed__23))]
	private IEnumerator StopAni()
	{
		return null;
	}

	private void StopAniImmediately()
	{
	}

	private IList<Skill_slotin> GetRandomList()
	{
		return null;
	}

	private IList<Skill_slotin> GetNeedSkill()
	{
		return null;
	}

	private int GetWeight(Skill_slotin sender)
	{
		return 0;
	}

	private void OnAniEnd(int pIndex)
	{
	}

	private void OnClickBack()
	{
	}

	private void OnBuyEnd(MazeSkillMagicianItemCtl sender)
	{
	}

	private void ClickJumpAniBtn()
	{
	}
}
