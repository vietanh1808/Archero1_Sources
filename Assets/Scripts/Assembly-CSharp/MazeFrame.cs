using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

public class MazeFrame : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayBokenAni_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MazeFrame _003C_003E4__this;

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
		public _003CPlayBokenAni_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CPlayTurnAroundAni_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MazeFrame _003C_003E4__this;

		private int _003Cprocess_003E5__2;

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
		public _003CPlayTurnAroundAni_003Ed__22(int _003C_003E1__state)
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
	private MazeItem[] Itemcells;

	[SerializeField]
	private DxxImage image_Select;

	[SerializeField]
	private DxxImage image_Door;

	[SerializeField]
	private SkeletonGraphic sk_Hammer;

	[SerializeField]
	private SpineEventHelper seh_Hammer;

	public int circleIndex;

	private int target;

	private float waitTime;

	private float allTime;

	private int selectIndex;

	private int count;

	private bool isSpecial;

	private bool crtAutoState;

	private Action AniEnd;

	private ActivityMazeMgr mazeMgr => null;

	private void Awake()
	{
	}

	public void SetAniStartAndEndEvent()
	{
	}

	public void InitCells()
	{
	}

	public void SetHammerParent(Transform hammerParent)
	{
	}

	public void Shuffle()
	{
	}

	public void PlayCircleAni(bool autoState, int targetIndex, bool isSp, Action endAni = null)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayTurnAroundAni_003Ed__22))]
	private IEnumerator PlayTurnAroundAni()
	{
		return null;
	}

	public void PlayHammerAni()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayBokenAni_003Ed__24))]
	public IEnumerator PlayBokenAni()
	{
		return null;
	}

	public void HammerStartEvent()
	{
	}
}
