using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1618 : SkillAloneBase
{
	public class Skill1Effect1618IgniteVO : CustomJsonActionVO
	{
		public int Guid;
	}

	[CompilerGenerated]
	private sealed class _003CCreatSharkSequence_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int guid;

		public SkillAlone1618 _003C_003E4__this;

		private EntityBase _003Ctarget_003E5__2;

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
		public _003CCreatSharkSequence_003Ed__16(int _003C_003E1__state)
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

	private float pEffectRate;

	private float pCdTime;

	private float pHitInterval;

	private float pHitRatio;

	private float pHitRadius;

	private int pBuffId;

	private const int explodeBulletId = 1597;

	private const int fxId = 5100022;

	private const string SyncSkill1618 = "SyncSkill1618";

	private Dictionary<int, float> PreEffectDict;

	private Coroutine co;

	private GameObject sharkEff;

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData data)
	{
	}

	[IteratorStateMachine(typeof(_003CCreatSharkSequence_003Ed__16))]
	private IEnumerator CreatSharkSequence(int guid)
	{
		return null;
	}

	public BulletBase CreateSharkExplode(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private bool IsSingleEnermyInCD(int guid)
	{
		return false;
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void SyncCastSkillMsg(int guid)
	{
	}
}
