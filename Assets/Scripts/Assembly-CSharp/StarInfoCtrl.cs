using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class StarInfoCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelaySetVal_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StarInfoCtrl _003C_003E4__this;

		public int begin;

		public int max;

		public float deltaTime;

		public int target;

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
		public _003CDelaySetVal_003Ed__20(int _003C_003E1__state)
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

	public Slider ProgressBar;

	public Text LevelInfo;

	public Animator LevelUpgrade;

	public int PropLevel { get; private set; }

	public int LevelMax { get; private set; }

	public float LevelProgress { get; private set; }

	private void Awake()
	{
	}

	public void SetValue(int level, int max)
	{
	}

	public void PlayToTarget(int begin, int target, int max)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void RefreshUI()
	{
	}

	[IteratorStateMachine(typeof(_003CDelaySetVal_003Ed__20))]
	private IEnumerator DelaySetVal(int begin, int target, int max, float deltaTime)
	{
		return null;
	}
}
