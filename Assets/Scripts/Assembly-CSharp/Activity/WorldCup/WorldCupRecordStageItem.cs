using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Activity.WorldCup
{
	public class WorldCupRecordStageItem : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COnUpdate_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WorldCupRecordStageItem _003C_003E4__this;

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
			public _003COnUpdate_003Ed__10(int _003C_003E1__state)
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
		private DxxText txtRatio;

		[SerializeField]
		private DxxText txtStage;

		[SerializeField]
		private DxxText txtEndTips;

		[SerializeField]
		private DxxImage imgBg;

		[SerializeField]
		private Sprite spNorm;

		[SerializeField]
		private Sprite spHighlight;

		private Coroutine _coroutine;

		private WaitForSeconds _wait;

		private ChampionBetSchedule _schedule;

		private long CD => 0L;

		public void Set(ChampionBetSchedule schedule)
		{
		}

		[IteratorStateMachine(typeof(_003COnUpdate_003Ed__10))]
		private IEnumerator OnUpdate()
		{
			return null;
		}

		private void UpdateCdText()
		{
		}

		private void CheckWait()
		{
		}
	}
}
