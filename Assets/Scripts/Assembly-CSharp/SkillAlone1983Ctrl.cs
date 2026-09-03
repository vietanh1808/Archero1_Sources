using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1983Ctrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCDEnd_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1983Ctrl _003C_003E4__this;

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
		public _003CCDEnd_003Ed__14(int _003C_003E1__state)
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

	private float CONFIG_SKILL_BOMB_HIT_RATIO;

	private float CONFIG_SKILL_RADIUS;

	private EntityBase m_Entity;

	private WaitForSeconds m_wait;

	private Action m_endCallback;

	private Action<EntityBase> m_enterCallback;

	private Action<EntityBase> m_exitCallback;

	[SerializeField]
	private GameObject m_goBomb;

	[SerializeField]
	private SphereCollider m_collider;

	[SerializeField]
	private AutoDespawn m_AutoDespawn;

	private Dictionary<EntityBase, float> m_dicEnemyDistances;

	private bool m_bCDEndFlag;

	public void Init(EntityBase entity, float fBombHitRatio, float fTime, float fRadius, Action endCallback, Action<EntityBase> enterCallback, Action<EntityBase> exitCallback)
	{
	}

	public void DeInit()
	{
	}

	[IteratorStateMachine(typeof(_003CCDEnd_003Ed__14))]
	private IEnumerator CDEnd()
	{
		return null;
	}

	public void OnUpdate(float delta)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void Bomb()
	{
	}
}
