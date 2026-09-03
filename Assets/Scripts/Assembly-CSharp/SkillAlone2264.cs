using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2264 : SkillAloneBase
{
	private class Skill2264_CastShockWave : CustomJsonActionVO
	{
		public Vector3 Pos;

		public Vector3 Forward;
	}

	private class Skill2264_Gifts : CustomJsonActionVO
	{
		public List<Vector3> PosList;
	}

	[CompilerGenerated]
	private sealed class _003CGenGift_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2264 _003C_003E4__this;

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
		public _003CGenGift_003Ed__19(int _003C_003E1__state)
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

	private float triggerRate;

	private float sectorRadius;

	private float initOffset;

	private float includedAngle;

	private float expandTime;

	private float hitRatio;

	private float triggerOneRate;

	private float triggerTwoRate;

	private int buffId;

	private float CDTime;

	private float giftDuration;

	private float preEffectTime;

	private SkillAlone2264GoodCtrl goodCtrl;

	private const string GiftEffPath = "Game/SkillPrefab/SkillAlone2264Gift";

	private Coroutine genGiftCo;

	private List<Vector2Int> gridList;

	private List<Vector3> gridPosResultList;

	private const string SyncSkill2264_WaveEff = "SyncSkill2263_WaveEff";

	private const string SyncSkill2264_Gifts = "SyncSkill2263_Gifts";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void CastShockWave()
	{
	}

	[IteratorStateMachine(typeof(_003CGenGift_003Ed__19))]
	private IEnumerator GenGift()
	{
		return null;
	}

	private void CastWaveEff(Vector3 pos, Vector3 forward)
	{
	}

	private void GenerateGifts(List<Vector3> list)
	{
	}

	private int RandomGiftCount()
	{
		return 0;
	}

	private List<Vector2Int> GetGridsInSector(Vector3 center, Vector3 forward, float radius, float angle)
	{
		return null;
	}

	private bool IsInSector(Vector3 center, Vector3 forward, float radius, float includedAngle, Vector3 destPos)
	{
		return false;
	}

	private void IsEnterKnightKing(bool isKnight)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncWaveEff(Vector3 pos, Vector3 forward)
	{
	}

	private void SyncGifts(List<Vector3> list)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
