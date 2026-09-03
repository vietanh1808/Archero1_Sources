using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1356EffectCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTimeEnd_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1356EffectCtrl _003C_003E4__this;

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
		public _003CTimeEnd_003Ed__18(int _003C_003E1__state)
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

	[SerializeField]
	private EntityParentBase m_EntityParentBase;

	[SerializeField]
	private CapsuleCollider m_collider;

	private EntityBase m_Entity;

	private float m_fTime;

	private float m_fStartTime;

	private float m_fHitInterval;

	private float m_fHitRatio;

	private Action m_EndAction;

	private Dictionary<EntityBase, float> m_dicHitEntityTime;

	public void Init(EntityBase entity, float fTime, float fHitRatio, Action EndAction)
	{
	}

	public void DeInit()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnCollisionStay(Collision other)
	{
	}

	private void OnTriggerEnter(Collider o)
	{
	}

	private void OnTriggerStay(Collider o)
	{
	}

	private void Trigger(GameObject go)
	{
	}

	private void TriggerEnter(EntityBase entity)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	[IteratorStateMachine(typeof(_003CTimeEnd_003Ed__18))]
	private IEnumerator TimeEnd()
	{
		return null;
	}
}
