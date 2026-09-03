using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2257 : SkillAloneBase
{
	private class SkillEffect2257_SyncThunderHitVO : CustomJsonActionVO
	{
		public long Hit;

		public int TarGuid;
	}

	private class SkillEffect2257_SyncIceEffVO : CustomJsonActionVO
	{
		public int TarGuid;
	}

	private class SkillEffect2257_SyncDoubleIceHitVO : CustomJsonActionVO
	{
		public long Hit;

		public int TarGuid;
	}

	private class SkillEffect2257_SyncThunderCloudVO : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	private class SkillEffect2257_SyncBllizzardVO : CustomJsonActionVO
	{
		public int TarGuid;
	}

	private class SkillEffect2257_SyncHudExplodeVO : CustomJsonActionVO
	{
		public int TarGuid;

		public string EffPath;
	}

	[CompilerGenerated]
	private sealed class _003CCreatCloudCo_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EntityBase entity;

		public SkillAlone2257 _003C_003E4__this;

		private Vector3 _003CcloudInitPos_003E5__2;

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
		public _003CCreatCloudCo_003Ed__43(int _003C_003E1__state)
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
	private sealed class _003CDoubleIceCo_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EntityBase entity;

		public SkillAlone2257 _003C_003E4__this;

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
		public _003CDoubleIceCo_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CStormSequence_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2257 _003C_003E4__this;

		public EntityBase entity;

		private Vector3 _003CdestPos_003E5__2;

		private int _003CstormTimes_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CStormSequence_003Ed__47(int _003C_003E1__state)
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

	private float addIceRate;

	private float addThunderRate;

	private float thunderHitRise;

	private int iceDebuffId;

	private float combineCDTime;

	private float thunderCloudRadius;

	private float thunderHitInterval;

	private float thunderHitRatio;

	private float doubleIceHitRatio;

	private float iceStormRadius;

	private float iceStormHitRatio;

	private float iceStormInterval;

	private int frozenTimes;

	private int dizzyBuffId;

	private float stormDuration;

	private float frozenTimesClearInterval;

	private const int CLOUD_BULLET_ID = 1568;

	private bool isIceOn;

	private bool isThunderOn;

	private Dictionary<int, int> markDict;

	private Dictionary<int, float> markCDDict;

	private Dictionary<int, int> frozenTimesDict;

	private Dictionary<int, float> lastFrozenTimeDict;

	private const int bllizzardBulletId = 1567;

	private const string iceHitEff = "Effect/Battle/eff_icezeus_receive_ice";

	private const string thunderHitEff = "Effect/Battle/eff_icezeus_receive_thunder";

	private const string blizzarEffPath = "Effect/Battle/eff_icezeus_trigger_icethunder";

	private const string doubleIceHitEffPath = "Effect/Battle/eff_icezeus_trigger_doubleice";

	private const string doubleIceHudEff = "Effect/Battle/eff_icezeus_boom_doubleice";

	private const string doubleThunderHudEff = "Effect/Battle/eff_icezeus_boom_doublethunder";

	private const string iceThunderHudEff = "Effect/Battle/eff_icezeus_boom_icethunder";

	private const string iceMarkHudEff = "Effect/Battle/eff_icezeus_mark_ice";

	private const string thunderMarkHudEff = "Effect/Battle/eff_icezeus_mark_thunder";

	private GameObject leftHudNode;

	private GameObject rightHudNode;

	private List<BulletBase> cloudBullet;

	private List<GameObject> blizzard;

	private List<Coroutine> blizzardCo;

	private const string SyncSkill2257_SyncThunderHit = "SyncSkill1621_SyncThunderHit";

	private const string SyncSkill2257_SyncIceEff = "SyncSkill2257_SyncIceEff";

	private const string SyncSkill2257_SyncDoubleIceHit = "SyncSkill2257_SyncDoubleIceHit";

	private const string SyncSkill2257_SyncThunderCloud = "SyncSkill2257_SyncThunderCloud";

	private const string SyncSkill2257_SyncBllizzard = "SyncSkill2257_SyncBllizzard";

	private const string SyncSkill2257_SyncHudExplode = "SyncSkill2257_SyncHudExplode";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	private void SetHudEff(string effPath, EntityBase entity)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	[IteratorStateMachine(typeof(_003CDoubleIceCo_003Ed__42))]
	private IEnumerator DoubleIceCo(EntityBase entity)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCreatCloudCo_003Ed__43))]
	private IEnumerator CreatCloudCo(EntityBase entity)
	{
		return null;
	}

	private BulletBase CreatCloud(Vector3 cloudInitPos)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStormSequence_003Ed__47))]
	private IEnumerator StormSequence(EntityBase entity)
	{
		return null;
	}

	public BulletBase CreateSingleStorm(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void SyncThunderHit(long hit, int tarGuid)
	{
	}

	private void SyncIceEff(int tarGuid)
	{
	}

	private void SyncDoubleIceHit(long hit, int tarGuid)
	{
	}

	private void SyncThunderCloud(Vector3 pos)
	{
	}

	private void SyncBllizzard(int guid)
	{
	}

	private void SyncHudEff(int guid, string effPath)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
