using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1262 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CAddSickle_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1262 _003C_003E4__this;

		public EntityBase entity;

		private GameObject _003Cobj_003E5__2;

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
		public _003CAddSickle_003Ed__11(int _003C_003E1__state)
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

	private float m_fSickleTime;

	private Dictionary<EntityBase, Coroutine> m_dicTimers;

	private WaitForSeconds m_intervalWait1;

	private WaitForSeconds m_intervalWait2;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAddEnemy(EntityBase entity)
	{
	}

	private void OnEnemyWillDead(EntityBase entity)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void ClearTimer()
	{
	}

	[IteratorStateMachine(typeof(_003CAddSickle_003Ed__11))]
	private IEnumerator AddSickle(EntityBase entity)
	{
		return null;
	}
}
