using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class SkillAlone2103 : SkillAloneWing
{
	[CompilerGenerated]
	private sealed class _003CCastSingle_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public SkillAlone2103 _003C_003E4__this;

		public float damScale;

		public float backRate;

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
		public _003CCastSingle_003Ed__29(int _003C_003E1__state)
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

	private float effectCDTime;

	private float skillDmgScale;

	private float skillRadius;

	private float skillSpeed;

	private float backRate;

	private int IsSkill1Effect;

	private float CdTime;

	private float preEffectTime;

	private int IsSkill2Effect;

	private int debuffId;

	private int IsSkill3Effect;

	private int waveCount;

	private float waveInterval;

	private float[] damageRises;

	private float[] newBackRates;

	private int IsSkill4Effect;

	private float cdTimeReducedPerUnit;

	private float cdTimeReducedLimit;

	private float lastMakeDmgTime;

	private SkillAlone2103GoodCtrl goodCtrl;

	private int curIndex;

	private float cdReduced;

	protected override void OnInstall()
	{
	}

	private void ParseSkillParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void CheckPlayerStatus(float delta)
	{
	}

	private void CastSingle()
	{
	}

	private void CastMulti()
	{
	}

	private void CastSkill(float dmgScale, float backRate)
	{
	}

	private void MultiCastSkill(int times, float interval, float[] damageRises, float[] newBackRates)
	{
	}

	[IteratorStateMachine(typeof(_003CCastSingle_003Ed__29))]
	private IEnumerator CastSingle(float waitTime, float damScale, float backRate)
	{
		return null;
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	private void ReduceCdTime(int index)
	{
	}
}
