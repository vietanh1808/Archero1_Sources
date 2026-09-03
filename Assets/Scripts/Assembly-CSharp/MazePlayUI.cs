using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MazePlayUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public MazePlayUI _003C_003E4__this;

		public bool isGo;
	}

	[CompilerGenerated]
	private sealed class _003CStartAutoTurnAni_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MazePlayUI _003C_003E4__this;

		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

		private LocalSave.EquipOne _003Cprop_003E5__2;

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
		public _003CStartAutoTurnAni_003Ed__10(int _003C_003E1__state)
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
	private MazeFrame frame_Out;

	[SerializeField]
	private MazeFrame frame_mid;

	[SerializeField]
	private MazeFrame frame_In;

	private ActivityMazeMgr mazeMgr => null;

	public void Init(Transform hammerParent)
	{
	}

	public void InitFrame()
	{
	}

	public void Shuffle()
	{
	}

	public void PlayGame()
	{
	}

	public void PlayCircleAni(int crtCircle, bool isSpecial, int target, bool autoState = false, Action aniEnd = null)
	{
	}

	[IteratorStateMachine(typeof(_003CStartAutoTurnAni_003Ed__10))]
	private IEnumerator StartAutoTurnAni()
	{
		return null;
	}
}
