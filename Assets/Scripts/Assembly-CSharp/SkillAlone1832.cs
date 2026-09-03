using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1832 : SkillAloneBase
{
	public class Skill1832_SyncSubmitBuff : CustomJsonActionVO
	{
		public int Guid;
	}

	public class Skill1832_SyncSubmitHit : CustomJsonActionVO
	{
		public int Guid;

		public long Hit;
	}

	public class Skill1832_SyncPressEff : CustomJsonActionVO
	{
		public int Guid;
	}

	[CompilerGenerated]
	private sealed class _003CAddAuraEffCor_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1832 _003C_003E4__this;

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
		public _003CAddAuraEffCor_003Ed__20(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CAddBuffDelay_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1832 _003C_003E4__this;

		public int guid;

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
		public _003CAddBuffDelay_003Ed__25(int _003C_003E1__state)
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

	private float impulseHitRise;

	private float impulseDurationRise;

	private float impulseCDTimeRise;

	private float submitBuffRate;

	private int submitBuffId;

	private float submitDelayTime;

	private float submitHitRatio;

	private int afterSubmitBuffId;

	private float submitCDTime;

	private int oppressBuffId;

	private const string AuraEffPath = "Game/Aura/AuraLion";

	private GameObject auraEff;

	private const string alarmEff = "Effect/Battle/eff_lionarthur_surrender01";

	private const string surrenderExplodeEff = "Effect/Battle/eff_lionarthur_surrenderboom";

	private const string surrenderHitEff = "Effect/Battle/eff_lionarthur_hit";

	private const string lionArthurPress = "Effect/Battle/eff_lionarthur_press";

	private Dictionary<int, float> submitBuffCdDict;

	private const string SyncSkill1832_SyncSubmitBuff = "SyncSkill1832_SyncSubmitBuff";

	private const string SyncSkill1832_SyncSubmitHit = "SyncSkill1832_SyncSubmitHit";

	private const string SyncSkill1832_SyncPressEff = "SyncSkill1832_SyncPressEff";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	[IteratorStateMachine(typeof(_003CAddAuraEffCor_003Ed__20))]
	private IEnumerator AddAuraEffCor()
	{
		return null;
	}

	private void AddAuraEff()
	{
	}

	private void RemoveAuraEff()
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData hd)
	{
	}

	private void ShowAlarmEff(EntityBase target)
	{
	}

	[IteratorStateMachine(typeof(_003CAddBuffDelay_003Ed__25))]
	private IEnumerator AddBuffDelay(int guid)
	{
		return null;
	}

	private void OnMonsterDead(EntityBase enemy)
	{
	}

	private void OnBuffRemovedByTime(EntityBase entity, int buffId)
	{
	}

	private void SyncSubmitBuff(int guid)
	{
	}

	private void SyncSubmitHit(int guid, long hit)
	{
	}

	private void SyncPressEff(int guid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
