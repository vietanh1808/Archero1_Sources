using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EntityArtifactBase : EntityCallBase
{
	[CompilerGenerated]
	private sealed class _003CDelayGameOver_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CDelayGameOver_003Ed__3(int _003C_003E1__state)
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

	private Coroutine gameOverCo;

	private bool isHeroEntered;

	protected override void OnInitAfter()
	{
	}

	protected override void OnEntityDead()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayGameOver_003Ed__3))]
	private IEnumerator DelayGameOver()
	{
		return null;
	}

	protected override void OnTriggerEnterExtra(Collider collider)
	{
	}

	protected override void OnTriggerExitExtra(Collider collider)
	{
	}

	public void Init(int id, float time)
	{
	}

	protected override void OnInitBefore()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void StartInit()
	{
	}

	protected virtual int GetDefaultHPSliderId()
	{
		return 0;
	}

	protected virtual bool IsInvincible()
	{
		return false;
	}

	protected virtual bool GetColliderEnabled()
	{
		return false;
	}

	protected virtual bool CanShowHP()
	{
		return false;
	}

	protected override void InitAnimations()
	{
	}

	protected override void OnDeInitLogic()
	{
	}

	protected override void UpdateProcess(float delta)
	{
	}

	protected virtual void PartBodyUpdate(float delta)
	{
	}

	protected override void OnDeInit()
	{
	}
}
