using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Util;

public class SkillAlone1356 : SkillAloneBase
{
	private class SwordShow
	{
		public string ShowPre;

		public string ShowEnd;

		public string ShowAttacking;

		public int EffectId;
	}

	[CompilerGenerated]
	private sealed class _003CCheckWillDead_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1356 _003C_003E4__this;

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
		public _003CCheckWillDead_003Ed__27(int _003C_003E1__state)
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

	public const string ShowPre = "SwordShowPre";

	public const string ShowEnd = "SwordShowEnd";

	public const string ShowAttacking = "SwordShowAttacking";

	public const string DuelShowPre = "DuelSwordShowPre";

	public const string DuelShowEnd = "DuelSwordShowEnd";

	public const string DuelShowAttacking = "DuelSwordShowAttacking";

	private SequencePool mSeqPool;

	private Dictionary<int, SwordShow> m_dicMappingWeapons;

	private float m_fTime;

	private float m_fMaxTime;

	private float m_fRatio;

	private int m_nBuffId;

	private float m_fHitRatio;

	private SkillAlone1356EffectCtrl effect;

	private float m_fSuperSkillStartTime;

	private EntityHero m_hero;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private bool CanSuperSkill()
	{
		return false;
	}

	protected virtual void OnSuperSkill(bool value)
	{
	}

	private void SuperSkill()
	{
	}

	private void SuperSkillEnd()
	{
	}

	private void CacheEffect()
	{
	}

	private bool OnCheckSuperSkill()
	{
		return false;
	}

	private void OnWillDead()
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	[IteratorStateMachine(typeof(_003CCheckWillDead_003Ed__27))]
	private IEnumerator CheckWillDead()
	{
		return null;
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
