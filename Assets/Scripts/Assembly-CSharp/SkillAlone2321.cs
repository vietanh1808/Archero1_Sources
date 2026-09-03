using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2321 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill2321VO : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public SkillAlone2321 _003C_003E4__this;

		public Vector3 pos;

		internal void _003CDelayCreateStar_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCreateExplode_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2321 _003C_003E4__this;

		public Vector3 Pos;

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
		public _003CCreateExplode_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CDelayCreateStar_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2321 _003C_003E4__this;

		public Vector3 pos;

		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

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
		public _003CDelayCreateStar_003Ed__14(int _003C_003E1__state)
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

	private float dropRadius;

	private float firstHitRatio;

	private float secondHitRatio;

	private float hitInterval;

	private const int StarBulletId = 3082;

	private const int ExplodeBulletId = 3083;

	private const string SyncSkill2321 = "SyncSkill2321";

	private Coroutine co;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnDizzy(bool isDizzy, BuffAloneBase buff)
	{
	}

	private void DoCreateStar(Vector3 pos)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCreateStar_003Ed__14))]
	private IEnumerator DelayCreateStar(Vector3 pos)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCreateExplode_003Ed__15))]
	private IEnumerator CreateExplode(Vector3 Pos)
	{
		return null;
	}

	private void CreateExplodeHit(Vector3 pos, float atkPercent, float radius)
	{
	}

	private void SyncCreateStar(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
