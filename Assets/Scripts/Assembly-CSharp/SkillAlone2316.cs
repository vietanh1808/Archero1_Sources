using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2316 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill2316VO : CustomJsonActionVO
	{
		public Vector3 CenterPos;
	}

	[CompilerGenerated]
	private sealed class _003CCreateCrossSlashDelay_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2316 _003C_003E4__this;

		public Vector3 pos;

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
		public _003CCreateCrossSlashDelay_003Ed__10(int _003C_003E1__state)
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

	private float bulletLength;

	private float bulletWidth;

	private float hitRatio;

	private int buffId;

	private const int ExplodeBulletId = 1614;

	private const string SyncSkill2316 = "SyncSkill2316";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnMeteorStateExit()
	{
	}

	[IteratorStateMachine(typeof(_003CCreateCrossSlashDelay_003Ed__10))]
	private IEnumerator CreateCrossSlashDelay(Vector3 pos)
	{
		return null;
	}

	private void DoCreateCrossSlash(Vector3 centerPos)
	{
	}

	private void CreateCrossSlash(Vector3 centerPos)
	{
	}

	private void SyncCrossSlash(Vector3 centerPos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
