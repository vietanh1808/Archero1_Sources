using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1260 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CInvincible_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1260 _003C_003E4__this;

		public EntityBase entity;

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
		public _003CInvincible_003Ed__9(int _003C_003E1__state)
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

	private List<int> m_listBuffIds;

	private Dictionary<EntityBase, Coroutine> m_dicTimers;

	private WaitForSeconds m_intervalWait;

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

	[IteratorStateMachine(typeof(_003CInvincible_003Ed__9))]
	private IEnumerator Invincible(EntityBase entity)
	{
		return null;
	}
}
