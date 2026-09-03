using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;

public class SkillAlone1183 : SkillAloneBabyBase
{
	[CompilerGenerated]
	private sealed class _003CDelayInit_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1183 _003C_003E4__this;

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
		public _003CDelayInit_003Ed__8(int _003C_003E1__state)
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

	private EntityBase mParent;

	private Goods_goods.GoodData m_goodData;

	private long m_lParentAttack;

	private List<Skill_slotin_npcskill> m_listNpcSkills;

	private int m_nWeightAll;

	private HashSet<int> m_skillSet;

	private long m_lLastOffset;

	protected override void OnInstall()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayInit_003Ed__8))]
	private IEnumerator DelayInit()
	{
		return null;
	}

	private void InitBabyAttrs()
	{
	}

	private void InitBabyNpcSlotinSkill()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttackUpdate(long value)
	{
	}

	private void OnLevelUpBefore()
	{
	}

	private void OnLevelUpEvent(int level)
	{
	}
}
