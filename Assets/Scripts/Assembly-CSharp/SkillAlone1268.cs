using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1268 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CTimer_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1268 _003C_003E4__this;

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
		public _003CTimer_003Ed__9(int _003C_003E1__state)
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

	private float m_fTimeMin;

	private float m_fTimeMax;

	private int m_bBuffId;

	private Dictionary<EntityBase, Coroutine> m_listEnemies;

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

	[IteratorStateMachine(typeof(_003CTimer_003Ed__9))]
	private IEnumerator Timer()
	{
		return null;
	}
}
