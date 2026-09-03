using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Util;

public class SkillAlone1829 : SkillAloneBase
{
	public class Skill1829_LearnStarSkill : CustomJsonActionVO
	{
		public int SkillId;

		public int Guid;
	}

	public class Skill1829_EffCount : CustomJsonActionVO
	{
		public int Count;

		public int Guid;
	}

	[CompilerGenerated]
	private sealed class _003CLearnRandomSkill_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1829 _003C_003E4__this;

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
		public _003CLearnRandomSkill_003Ed__12(int _003C_003E1__state)
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

	private int learnSkillId1;

	private int learnSkillId2;

	private int learnWeight1;

	private int learnWeight2;

	private float addFireRate;

	private int fireBuffId;

	private WeightRandomCount weightSkillLearn;

	private Dictionary<int, int> enermyFireCountDict;

	private int fireMaxCount;

	private const string SyncSkill1829_LearnStarSkill = "SyncSkill1829_LearnStarSkill";

	private const string SyncSkill1829_EffCount = "SyncSkill1829_EffCount";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	[IteratorStateMachine(typeof(_003CLearnRandomSkill_003Ed__12))]
	private IEnumerator LearnRandomSkill()
	{
		return null;
	}

	private void LearnSkillWhenInit()
	{
	}

	private int GetToLearnSkillId()
	{
		return 0;
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData hd)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnBuffRemoved(EntityBase entity, int buffId)
	{
	}

	private void SyncLearnStarSkill(int skillId)
	{
	}

	private void SyncEffCount(int count, int guid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
