using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Util;
using UnityEngine;

public class SkillAlone1629 : SkillAloneBase
{
	public class Skill1629_GoldenHit : CustomJsonActionVO
	{
		public long Hit;

		public int TarGuid;

		public int SourceGuid;
	}

	[CompilerGenerated]
	private sealed class _003CDelayCallPvE_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1629 _003C_003E4__this;

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
		public _003CDelayCallPvE_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CDelayCallPvP_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1629 _003C_003E4__this;

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
		public _003CDelayCallPvP_003Ed__41(int _003C_003E1__state)
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

	private int GoldenBossWeight;

	private int RedBossWeight;

	private int PurpleBossWeight;

	private int CyanBossWeight;

	private int GoldenMonsterWeight;

	private int RedMonsterWeight;

	private int PurpleMonsterWeight;

	private int CyanMonsterWeight;

	private int killMonsterCountLow;

	private int killMonsterCountHigh;

	private float stickRiseRate;

	private int killMonsterHighBuffId;

	private float goldHitCalDuration;

	private float goldHitRatio;

	private float redExplodeRadius;

	private float redExplodeRatio;

	private float purpleRate;

	private float cyanRecoverRate;

	private WeightRandomCount weightRandomBoss;

	private WeightRandomCount weightRandomMonster;

	private Dictionary<int, int> firstHitDict;

	private Dictionary<int, float> goldenAllHitDict;

	private Dictionary<int, float> goldenTimeDict;

	private int monsterKilledCount;

	private int redExplodeBulletId;

	private int goldBuffId;

	private int redBuffId;

	private int purpleBuffId;

	private int cyanBuffId;

	private string colorPropertyName;

	private Material[] mats;

	private List<int> tempRemoveIds;

	private const string SyncSkill1629_GoldenHit = "SyncSkill1629_GoldenHit";

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

	private void OnUpdate(float delta)
	{
	}

	private void DeadAction(EntityBase entity)
	{
	}

	private void UpdateCountEffect(int KilledCount, bool isInit)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	public BulletBase CreateExplodeHit(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDelayCallPvP_003Ed__41))]
	private IEnumerator DelayCallPvP()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDelayCallPvE_003Ed__42))]
	private IEnumerator DelayCallPvE()
	{
		return null;
	}

	public void ChangeColor(SkinnedMeshRenderer skinnedMesh, Color newColor, int targetMaterialIndex)
	{
	}

	private void SyncGoldHit(int tarGuid, int sourceGuid, long hit)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
