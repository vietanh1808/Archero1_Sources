using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AdHarvestTimeLine : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public bool tattend;

		internal void _003CPlayOnce_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdHarvestTimeLine _003C_003E4__this;

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
		public _003CPlay_003Ed__9(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CPlayOnce_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdHarvestTimeLine _003C_003E4__this;

		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		private GameObject _003CobjHero_003E5__2;

		private EntityTimeLineHero _003CentityHero_003E5__3;

		private GameObject _003CobjMonster_003E5__4;

		private EntityTimeLineMoster _003CentityMonster_003E5__5;

		private Vector3 _003CposHero_003E5__6;

		private Vector3 _003CposEnemy_003E5__7;

		private Action _003Ctcmp_003E5__8;

		private int _003ChitCount_003E5__9;

		private int _003Ctmaxhit_003E5__10;

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
		public _003CPlayOnce_003Ed__16(int _003C_003E1__state)
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

	public Transform rootNode;

	protected readonly int[] mobIds;

	protected int[] skinIds;

	protected int[] weaponIds;

	protected const float speed = 3f;

	protected WaitForEndOfFrame frame;

	protected WaitForSeconds second1;

	protected bool shouldQuit;

	protected bool isPlaying;

	private int lastWpID;

	[IteratorStateMachine(typeof(_003CPlay_003Ed__9))]
	protected IEnumerator Play()
	{
		return null;
	}

	protected int GetRandomSkinId()
	{
		return 0;
	}

	protected int GetRandomWeapon()
	{
		return 0;
	}

	protected int GetRandomMonster()
	{
		return 0;
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayOnce_003Ed__16))]
	protected IEnumerator PlayOnce()
	{
		return null;
	}
}
