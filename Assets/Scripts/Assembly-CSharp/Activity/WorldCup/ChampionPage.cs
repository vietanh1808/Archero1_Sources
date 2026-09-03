using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Activity.WorldCup
{
	public class ChampionPage : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CNextFrame_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChampionPage _003C_003E4__this;

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
			public _003CNextFrame_003Ed__10(int _003C_003E1__state)
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

		[FormerlySerializedAs("infinityChampion")]
		[SerializeField]
		private WorldCupChampionBetInfinity infinity;

		[SerializeField]
		private WorldCupRecordStageItem[] stageItems;

		[SerializeField]
		private BetMakingChampPanel panel;

		[SerializeField]
		private ScrollRect sr;

		[SerializeField]
		private Slider slider;

		private OrderedDictionary<uint, WorldCupTeam> arr;

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

		[IteratorStateMachine(typeof(_003CNextFrame_003Ed__10))]
		private IEnumerator NextFrame()
		{
			return null;
		}
	}
}
