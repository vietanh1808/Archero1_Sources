using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpinWheel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSpinTheWheel_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpinWheel _003C_003E4__this;

		public float maxAngle;

		public float time;

		private float _003Ctimer_003E5__2;

		private float _003CstartAngle_003E5__3;

		private int _003Ccw_value_003E5__4;

		private int _003CanimationCurveNumber_003E5__5;

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
		public _003CSpinTheWheel_003Ed__19(int _003C_003E1__state)
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

	public List<AnimationCurve> animationCurves;

	public SuperRoulleteLightCtrl lightCtrl;

	public bool spinning;

	private float anglePerItem;

	private int randomTime;

	private int itemNumber;

	private bool rotateCommand;

	private int targetItemIndex;

	private bool CW;

	private Action EndCallBack;

	private float targetAngle;

	private int rate;

	private float rotateangle;

	private const float Speed = -20f;

	private bool isSkip;

	private void Start()
	{
	}

	public void RotateUp(int itemNum, int itemIndex, bool cw, Action callback, int rotRate = 1)
	{
	}

	public void RotateUp(float itemAngle, bool cw, Action callback, int rotRate = 1)
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CSpinTheWheel_003Ed__19))]
	private IEnumerator SpinTheWheel(float time, float maxAngle)
	{
		return null;
	}

	private float GetFitAngle(float angle)
	{
		return 0f;
	}

	public void DeInit()
	{
	}

	public void Skip()
	{
	}
}
