using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1621 : SkillAloneBase
{
	public class SkillEffect1621_MeteorVO : CustomJsonActionVO
	{
		public Vector3 pos;
	}

	[CompilerGenerated]
	private sealed class _003CCreateRingHits_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1621 _003C_003E4__this;

		public Vector3 pos;

		private int _003Ctimes_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CCreateRingHits_003Ed__29(int _003C_003E1__state)
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

	private int enterRoomBuffId;

	private int postStageBuffId;

	private float callMeteoriteRate;

	private float callMeteoriteInterval;

	private int meteoriteId;

	private float meteoriteRadius;

	private float meteoriteHitRatio;

	private float thunderRingDuration;

	private float thunderRingRadius;

	private float thunderRingInterval;

	private float thunderRingHitRatio;

	private int thunderRingMaxCount;

	private Vector3 StartPos;

	private const string ThunderRingEffPath = "Game/SkillPrefab/ZeusThunderGroundCircle";

	private int ringHitBulletId;

	private List<GameObject> allEffs;

	private List<Coroutine> allCoroutines;

	private List<BulletBase> allHitBullets;

	private Dictionary<int, float> preCallTimeDict;

	private Coroutine co;

	private GameObject ringEff;

	private const string SyncSkill1621_SyncMeteor = "SyncSkill1621_SyncMeteor";

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnBuffRemoved(EntityBase entity, int buffId)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void CreateThunderRing(Vector3 pos)
	{
	}

	private void StopCo()
	{
	}

	[IteratorStateMachine(typeof(_003CCreateRingHits_003Ed__29))]
	private IEnumerator CreateRingHits(Vector3 pos)
	{
		return null;
	}

	public BulletBase CreateRingHit(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private int GetCurRingCount()
	{
		return 0;
	}

	private void OnHeroMeshChanged(BodyMask mask)
	{
	}

	private void SyncMeteor(Vector3 destPos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
