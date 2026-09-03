using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2330 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill2330VO : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	[CompilerGenerated]
	private sealed class _003CDelayGotoNextRoom_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2330 _003C_003E4__this;

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
		public _003CDelayGotoNextRoom_003Ed__20(int _003C_003E1__state)
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

	private float summonRate;

	private int sickleMaxCount;

	private float dmgBoostPerSummon;

	private int totalSummonCap;

	private float sickleDuration;

	private const int SicklePartId = 1818;

	private const string SyncSkill2330_Summon = "SyncSkill2330_Summon";

	private long currentAtkBonus;

	private readonly List<EntityPartBodyBase> sickleList;

	private Coroutine gotoNextRoomCoroutine;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHeadShot(EntityBase attackTarget, bool bLessHpHeadShot)
	{
	}

	private void DoSummonSickle(Vector3 pos)
	{
	}

	private void OnCreatePartBody(EntityPartBodyBase part)
	{
	}

	private void OnPartBodyRemove(int partbodyid)
	{
	}

	private void OnPartBodyDisapear(EntityPartBodyBase body)
	{
	}

	private int GetTotalSummonCount()
	{
		return 0;
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayGotoNextRoom_003Ed__20))]
	private IEnumerator DelayGotoNextRoom()
	{
		return null;
	}

	private void RefreshAtkBonus(int partBodyDelta = 0)
	{
	}

	private void RemoveAtkBonus()
	{
	}

	private void CleanDeadSickles()
	{
	}

	private Vector3 GetSummonPos()
	{
		return default;
	}

	private void SyncSummon(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
