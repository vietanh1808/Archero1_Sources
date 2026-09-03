using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2106 : SkillAloneWing
{
	public class Skill1Effect2106IgniteVO_SingleStar : CustomJsonActionVO
	{
		public Vector3 startPos;

		public Vector3 endPos;
	}

	public class Skill1Effect2106IgniteVO_SingleMeteor : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	public class Skill1Effect2106IgniteVO_FlySwords : CustomJsonActionVO
	{
		public List<Vector3> posList;

		public List<float> rotateList;
	}

	[CompilerGenerated]
	private sealed class _003CCreateMeteors_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2106 _003C_003E4__this;

		public int count;

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
		public _003CCreateMeteors_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CRandomGenerateItems_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public SkillAlone2106 _003C_003E4__this;

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
		public _003CRandomGenerateItems_003Ed__46(int _003C_003E1__state)
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

	private int callMeteorRate;

	private int callStarRate;

	private int callSwordRate;

	private int callHeartRate;

	private int callOneWeight;

	private int callTwoWeight;

	private int callThreeWeight;

	private int callFourWeight;

	private int meteorBulletId;

	private float callRadius;

	private float innerRadius;

	private float innerHitRatio;

	private float outRadius;

	private float outHitRatio;

	private int starBulletId;

	private float dropRadius;

	private float starHitHitratio;

	private int flySwordBulletId;

	private float flySwordHitRatio;

	private float flySwordAngularVelocity;

	private float flySwordTrackTime;

	private int hpDropRadius;

	private int IsSkill1Effect;

	private int IsSkill2Effect;

	private int newFlySwordBulletId;

	private float decreaseRatio;

	private float minRatio;

	private int IsSkill3Effect;

	private int lowerAdd;

	private int upperAdd;

	private int[] weightArr;

	private int IsSkill4Effect;

	private float callExraHeartRate;

	private int ExraHeartCount;

	private bool isMonsterCreated;

	private float callMeteoroliteInterval;

	private Coroutine m_coroutine;

	private Coroutine m_mainCoroutine;

	private const string SyncSkill2106_SingleStar = "SyncSkill2106_SingleStar";

	private const string SyncSkill2106_SingleMeteor = "SyncSkill2106_SingleMeteor";

	private const string SyncSkill2106_FlySwords = "SyncSkill2106_FlySwords";

	private List<Vector3> flySwordPosList;

	private List<float> flySwordAngleList;

	private ActionBasic action;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnWaveCreated(List<MapCreator.GoodsInfo> infos)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnGameType5WaveCreated()
	{
	}

	[IteratorStateMachine(typeof(_003CRandomGenerateItems_003Ed__46))]
	private IEnumerator RandomGenerateItems(float seconds)
	{
		return null;
	}

	private int GetRandomCount()
	{
		return 0;
	}

	private int GetNewRandomCount()
	{
		return 0;
	}

	private void CreateFlySord(int swordCount, int flySwordId)
	{
	}

	public virtual BulletBase CreateFlySwordEnhanced(int bulletId, Vector3 startpos, float angle, float hitRatio, EntityBase target)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCreateMeteors_003Ed__53))]
	private IEnumerator CreateMeteors(int count)
	{
		return null;
	}

	private void CreateStars(int count)
	{
	}

	private void CreatSingleStar(Vector3 startPos, Vector3 endPos)
	{
	}

	private void UpdateBulletTransmit(BulletBase bullet)
	{
	}

	protected override void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void SyncSingleMeteor(Vector3 Pos)
	{
	}

	private void SyncSingleStar(Vector3 startPos, Vector3 endPos)
	{
	}

	private void SyncFlySwords(List<Vector3> posList, List<float> rotateList)
	{
	}
}
