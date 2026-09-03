using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Activity.WorldCup
{
	public class MatchPage : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CNextFrame_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MatchPage _003C_003E4__this;

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
			public _003CNextFrame_003Ed__14(int _003C_003E1__state)
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
		private ButtonCtrl btnLeft;

		[SerializeField]
		private ButtonCtrl btnRight;

		[SerializeField]
		private WorldCupBetInfinity infinity;

		[SerializeField]
		private ScrollRect sr;

		private int curIndex;

		private WorldCupMatch[] matchData;

		[SerializeField]
		private BetMakingPanel makingPanel;

		public Action<long> onPageChanged;

		private void Awake()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void Refresh(bool init = false)
		{
		}

		private void OnBtnLeftClick()
		{
		}

		private void OnBtnRightClick()
		{
		}

		[IteratorStateMachine(typeof(_003CNextFrame_003Ed__14))]
		private IEnumerator NextFrame()
		{
			return null;
		}
	}
}
