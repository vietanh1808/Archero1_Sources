using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public static class DoTweenAssistant
{
	[CompilerGenerated]
	private sealed class _003CPlayBezierCurveAnimation_2_0_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action startCallback;

		public Vector3[] controlPoints;

		public int smoothness;

		public Transform target;

		public float duration;

		public AnimationCurve ease;

		public Action endCallback;

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
		public _003CPlayBezierCurveAnimation_2_0_003Ed__4(int _003C_003E1__state)
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

	private static SequencePool seq;

	public static void PlayBreathLightAnimation(Image target)
	{
	}

	public static void PlayBezierCurveAnimation_2(Transform target, Vector3[] controlPoints, float duration, int smoothness = 10, Action startCallback = null, Action endCallback = null, Ease ease = Ease.InOutQuad)
	{
	}

	public static void PlayBezierCurveAnimation_2(Transform target, Vector3[] controlPoints, float duration, AnimationCurve ease, int smoothness = 10, Action startCallback = null, Action endCallback = null)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayBezierCurveAnimation_2_0_003Ed__4))]
	public static IEnumerator PlayBezierCurveAnimation_2_0(Transform target, Vector3[] controlPoints, float duration, AnimationCurve ease, int smoothness = 10, Action startCallback = null, Action endCallback = null)
	{
		return null;
	}

	public static void PlayBezierCurveAnimation_2_1(Transform target, Vector3[] controlPoints, float duration, AnimationCurve ease, int smoothness = 10, Action startCallback = null, Action endCallback = null)
	{
	}

	public static void PlayBezierCurveAnimation_3(Transform target, Vector3[] controlPoints, float duration, int smoothness = 10, Action endCallback = null)
	{
	}

	private static Vector3[] Bezier2Path(Vector3 startPos, Vector3 controlPos, Vector3 endPos, int smoothness = 10)
	{
		return null;
	}

	private static Vector3[] Bezier3Path(Vector3 startPos, Vector3 controlPos1, Vector3 controlPos2, Vector3 endPos, int smoothness = 10)
	{
		return null;
	}

	public static Vector3 Bezier_2(Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
		return default;
	}

	public static void Bezier_2ref(ref Vector3 outValue, Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
	}

	public static Vector3 Bezier_3(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
		return default;
	}

	public static void Bezier_3ref(ref Vector3 outValue, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
	}
}
