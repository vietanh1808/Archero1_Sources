using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2310 : SkillAloneBase
{
	private class SyncVO : CustomJsonActionVO
	{
		public Vector3 Pos;

		public int TargetGuid;

		public Vector3 Forward;
	}

	[CompilerGenerated]
	private sealed class _003CDelayCall_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2310 _003C_003E4__this;

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
		public _003CDelayCall_003Ed__9(int _003C_003E1__state)
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

	private int maxStoreCount;

	private float storeCooldown;

	private float offSet;

	private int currentStoreCount;

	private float lastConsumeTime;

	private string updateTag;

	private bool isWearingTrident;

	private const string SyncSkill2310_GodSweep = "SyncSkill2310_GodSweep";

	protected override void OnInstall()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCall_003Ed__9))]
	private IEnumerator DelayCall()
	{
		return null;
	}

	private void LoadEff()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnDivinePunishTrigger(EntityBase target)
	{
	}

	private void TriggerGodSweep(EntityBase target)
	{
	}

	private void DoTriggerGodSweep(Vector3 pos, EntityBase target, Vector3 forward)
	{
	}

	private void SyncGodSweep(Vector3 pos, EntityBase target, Vector3 forward)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
