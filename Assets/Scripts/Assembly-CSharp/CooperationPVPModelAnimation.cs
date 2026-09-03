using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CooperationPVPModelAnimation
{
	[CompilerGenerated]
	private sealed class _003CMatchingModelAnimation_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CooperationPVPModelAnimation _003C_003E4__this;

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
		public _003CMatchingModelAnimation_003Ed__19(int _003C_003E1__state)
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

	private MonoBehaviour monoScript;

	private Transform animationSlot;

	protected List<int> playerIds;

	protected List<int> weaponIds;

	protected Dictionary<int, EntityTimeLineHero> cacheModel;

	private IEnumerator matchingAnimation;

	private EntityTimeLineHero curModel;

	private int lastModelIndex;

	public bool isPlaying { get; private set; }

	public CooperationPVPModelAnimation(MonoBehaviour pSc, Transform pSlot)
	{
	}

	public void RestModel()
	{
	}

	public void Dispose()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	protected int GetRandomPlayerId()
	{
		return 0;
	}

	protected int GetRandomWeapon()
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CMatchingModelAnimation_003Ed__19))]
	private IEnumerator MatchingModelAnimation()
	{
		return null;
	}

	private EntityTimeLineHero CreatRandomModel()
	{
		return null;
	}

	private EntityTimeLineHero CreatOneById(int pId)
	{
		return null;
	}
}
