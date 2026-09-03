using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone9033 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003COnUpdate_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone9033 _003C_003E4__this;

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
		public _003COnUpdate_003Ed__16(int _003C_003E1__state)
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

	private float dizzyRate;

	private int dizzyBuffId;

	private int hurtBuffId;

	private int reduceThunderBuffId;

	private float bodyOffset;

	private float _hitBuffIdInterval;

	private int maxDizzyTimes;

	private Dictionary<int, int> dizzyEffDict;

	private Dictionary<int, float> _dicDizzyHitTime;

	private WaitForSeconds _wait;

	private Coroutine _coroutine;

	private List<int> _keys;

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

	[IteratorStateMachine(typeof(_003COnUpdate_003Ed__16))]
	private IEnumerator OnUpdate()
	{
		return null;
	}

	private void OnBuffRemoved(EntityBase entity, int buffId)
	{
	}

	private void OnBuffAdded(EntityBase target, EntityBase source, int buffId)
	{
	}

	private void AddMaxDizzyTimes(int delta)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
