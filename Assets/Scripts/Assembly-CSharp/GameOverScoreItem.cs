using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cooperation;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreItem : MonoBehaviour
{
	public enum SideType
	{
		none = 0,
		left = 1,
		right = 2
	}

	[CompilerGenerated]
	private sealed class _003CScoreAnimation_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameOverScoreItem _003C_003E4__this;

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
		public _003CScoreAnimation_003Ed__13(int _003C_003E1__state)
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

	public Image icon;

	public DxxText text;

	public GameObject winner;

	public DxxText winnerText;

	public Image bar;

	private CooperationScoreObject data;

	private float animationMaxTime;

	private float animationTimer;

	private IEnumerator aniTor;

	public void SetData(CooperationScoreObject pData, float pPart, RectTransform parentBar, SideType pSide)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void PlayAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CScoreAnimation_003Ed__13))]
	private IEnumerator ScoreAnimation()
	{
		return null;
	}
}
