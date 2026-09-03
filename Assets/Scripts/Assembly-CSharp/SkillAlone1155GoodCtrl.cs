using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1155GoodCtrl : SkillAloneGoodCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CDelaySetRendderOrder_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1155GoodCtrl _003C_003E4__this;

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
		public _003CDelaySetRendderOrder_003Ed__15(int _003C_003E1__state)
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

	private ParticleSystemRenderer[] particles;

	private static readonly string sortingLayerName;

	private Action<int, SkillAlone1155GoodCtrl> OnTriggerEvent;

	private int m_nBuffId;

	private float m_fTime;

	public Vector2Int pos;

	public ParticleSystem particle;

	public Transform HeroContainer;

	private BoxCollider bxcollider;

	private Material material;

	private int Property_RimPower;

	private bool bPlayParticle;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	public SkillAlone1155GoodCtrl Init(EntityBase entity, EntityBase target, int buffId, float time, Vector2Int pos, Action<int, SkillAlone1155GoodCtrl> OnTriggerEvent)
	{
		return null;
	}

	private void CreateSoul(EntityBase entity)
	{
	}

	[IteratorStateMachine(typeof(_003CDelaySetRendderOrder_003Ed__15))]
	public IEnumerator DelaySetRendderOrder()
	{
		return null;
	}

	private void OnTriggerEnter(Collider o)
	{
	}

	protected override void UpdateProcess()
	{
	}

	public void DelayDeInit()
	{
	}
}
