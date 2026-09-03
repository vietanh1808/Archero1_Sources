using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1519 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CCallPartBody_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1519 _003C_003E4__this;

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
		public _003CCallPartBody_003Ed__14(int _003C_003E1__state)
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

	private float m_fInterval;

	private float m_fDuration;

	private float m_fHitAddPercent;

	private float m_fAttackSpeedAddPercent;

	private List<string> m_listAttrs;

	private bool m_bInitialized;

	private bool m_bTriggerInWaveRoom;

	private Coroutine m_Coroutine;

	private bool m_bIsWaveRoom;

	private WaitForSeconds m_wait;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnWaveRoomPlayerMove(Vector3 pos)
	{
	}

	[IteratorStateMachine(typeof(_003CCallPartBody_003Ed__14))]
	private IEnumerator CallPartBody()
	{
		return null;
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}
}
