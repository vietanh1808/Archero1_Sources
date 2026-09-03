using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2187 : SkillAloneBase
{
	public enum ImpulseType
	{
		Vertical = 0,
		Horizontal = 1
	}

	public class Skill1Effect2187IgniteVO_SycImpulse : CustomJsonActionVO
	{
		public ImpulseType type;

		public float damageRate;

		public float wide;

		public int targetGuid;
	}

	public class Skill1Effect2187IgniteVO_SycKnightKing : CustomJsonActionVO
	{
		public bool isKnightKing;
	}

	public class Skill1Effect2187IgniteVO_SycKnightKingPause : CustomJsonActionVO
	{
		public bool isKnightKingPause;
	}

	[CompilerGenerated]
	private sealed class _003CReloadTrailEff_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2187 _003C_003E4__this;

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
		public _003CReloadTrailEff_003Ed__67(int _003C_003E1__state)
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
	private sealed class _003CSwordSequence_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ImpulseType type;

		public Vector3 pos;

		public SkillAlone2187 _003C_003E4__this;

		public float wide;

		public float damageRate;

		private float _003CendTime_003E5__2;

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
		public _003CSwordSequence_003Ed__46(int _003C_003E1__state)
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

	private float callImpulseRate;

	private int dizzyBuffId;

	private float impulseDamageRate;

	private float firstImpulseDelay;

	private float impulseDuration;

	private float impulseInterval;

	private float CDTime;

	private float impulseWide;

	private float intoKnightKingTime;

	private int knightKingBuffId;

	private float callImpulseRateRise;

	private float CDTimeReduceRate;

	private float knightKingDuration;

	private float knightKingCDTime;

	private float kingDurationReducePerHit;

	private float damageRateHorizontal;

	private float impulseWideRiseRate;

	private float impulseDamageRiseRate;

	private int hitDebuffId;

	private float sliderPauseTime;

	private float impulseCDTimeAdd;

	private string ImpulseFxPathExternal;

	private string ImpulseEnemyFxPathExternal;

	private int verticalImpulseFxId;

	private float preImpulseSequenceTime;

	private float knightKingDurationExtra;

	private float knightKingCdExtra;

	private bool isNextImpulseMustHit;

	private float cdReduceToAgoTime;

	private const string ImpulseFxPath = "Effect/Battle/eff_arthur_sword_slash";

	private const string ImpulseEnemyFxPath = "Effect/Battle/eff_arthur_sword_slash_enemy";

	private const string SyncSkill2187_SycImpulse = "SyncSkill2187_SycImpulse";

	private const string SyncSkill2187_SycKnightKing = "SyncSkill2187_SycKnightKing";

	private const string SyncSkill2187_SycKnightKingPause = "SyncSkill2187_SycKnightKingPause";

	private bool canCastImpulse;

	private GameObject impulseEffectVertical;

	private GameObject impulseEffectHorizontal;

	private float preEnterMoveTime;

	private float preExitMoveTime;

	private float preEnterKnightKingTime;

	private float preExitKnightKingTime;

	private GameObject arthurKingEff;

	private GameObject arthurKingChangeEff;

	private GameObject arthurKingQuitEff;

	private GameObject arthurKingTrailEff;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void CastImpulse()
	{
	}

	private void CastImpulseWithCd()
	{
	}

	private void SetImpulseEffPath(string[] paths)
	{
	}

	private void CreateSwordSequence(ImpulseType type, float damageRate, float wide, Vector3 pos)
	{
	}

	[IteratorStateMachine(typeof(_003CSwordSequence_003Ed__46))]
	private IEnumerator SwordSequence(ImpulseType type, float damageRate, float wide, Vector3 pos)
	{
		return null;
	}

	private string GetImpulseEffPath()
	{
		return null;
	}

	private BulletBase CreateSingleImpulse(int bulletId, float damageRate, float wide, Vector3 pos, ImpulseType type)
	{
		return null;
	}

	private void OnMove(bool isMoving)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	private float GetImpulseRate()
	{
		return 0f;
	}

	private float GetImpulseCdTime()
	{
		return 0f;
	}

	private float GetKnightKingDuration()
	{
		return 0f;
	}

	private float GetKnightKingCdTime()
	{
		return 0f;
	}

	private void AddKnightKingDuration(float duration)
	{
	}

	private void IsEnterKnightKing(bool isKnight)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	[IteratorStateMachine(typeof(_003CReloadTrailEff_003Ed__67))]
	private IEnumerator ReloadTrailEff()
	{
		return null;
	}

	private void SetHorizontalDamageRate(float rate)
	{
	}

	private void OnImpulseEnhanced(float wideRiseRate, float damageRiseRate, int deBuffId)
	{
	}

	private void ImpulseDurationAdd(float addTime)
	{
	}

	private void ImpulseCDTimeAdd(float addTime)
	{
	}

	private void OnReduceEnterKnightKingCDTime(float time)
	{
	}

	private void OnSetIntoKnightKingTime(float time)
	{
	}

	private void NextImpulseMustHit()
	{
	}

	private void SetSliderPauseTime(float time)
	{
	}

	private void SycImpulse(ImpulseType type, float damageRate, float wide, int tGuid)
	{
	}

	private void SycKnightKing(bool isKing)
	{
	}

	private void SycKnightKingPause(bool isPause)
	{
	}

	protected override void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}
}
