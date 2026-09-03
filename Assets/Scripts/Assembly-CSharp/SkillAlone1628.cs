using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class SkillAlone1628 : SkillAloneBase
{
	public class Skill1628_SummerVitalityCount : CustomJsonActionVO
	{
		public int Count;
	}

	public class Skill1628_DolphinHit : CustomJsonActionVO
	{
		public int Guid;
	}

	public class Skill1628_EnermyDieInArea : CustomJsonActionVO
	{
		public long Heal;
	}

	[CompilerGenerated]
	private sealed class _003CChangeBoxingGloveEffectId_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EntityHero hero;

		public int id;

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
		public _003CChangeBoxingGloveEffectId_003Ed__33(int _003C_003E1__state)
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
	private sealed class _003CDolphinHitDelay_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EntityBase target;

		public SkillAlone1628 _003C_003E4__this;

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
		public _003CDolphinHitDelay_003Ed__34(int _003C_003E1__state)
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

	private float addEnergyRate;

	private int buffId;

	private int dolphinDebuffId;

	private float dolphinAtkRate;

	private float dolphinAtkDelay;

	private float dolphinAtkRitio;

	private float dolphinAtkCDTime;

	private float addLifeRate;

	private float dolphinAreaDuration;

	private float addDurationTime;

	private float addDurationMaxTime;

	private float dolphinAreaRadius;

	private int MaxEnergyCount;

	private int curEnergyCount;

	private Dictionary<int, float> enermyCDDict;

	private Dictionary<int, EntityBase> allEntitiesInAura;

	private DolphinAuraCtrl dolphinAuraCtrl;

	private float dolphinAuraDuration;

	private float dolphinAuraBornTime;

	private float preDolphinHitTime;

	private const int superSkillEffectId = 3411663;

	private bool isGetFlyWaterFromSkin;

	private int curRoomEffectCount;

	private const string SyncSkill1628_SummerVitalityCount = "SyncSkill1628_SummerVitalityCount";

	private const string SyncSkill1628_DolphinHit = "SyncSkill1628_DolphinHit";

	private const string SyncSkill1628_EnermyDieInArea = "SyncSkill1628_EnermyDieInArea";

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void CreatDolphinArea()
	{
	}

	private void DeadAction(EntityBase entity)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void DolphinHit(EntityBase target)
	{
	}

	private void ClearDolphinAura()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	[IteratorStateMachine(typeof(_003CChangeBoxingGloveEffectId_003Ed__33))]
	private IEnumerator ChangeBoxingGloveEffectId(EntityHero hero, int id)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDolphinHitDelay_003Ed__34))]
	private IEnumerator DolphinHitDelay(EntityBase target)
	{
		return null;
	}

	private void SyncSummerVitalityCount(int count)
	{
	}

	private void SyncDolphinHit(int guid)
	{
	}

	private void SyncEnermyDieInArea(long heal)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
