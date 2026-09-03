using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NewPlay125
{
	public class SingleWaveController
	{
		[CompilerGenerated]
		private sealed class _003CgenerateMonster_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SingleWaveController _003C_003E4__this;

			private int _003Cindex_003E5__2;

			private int _003CsafeCount_003E5__3;

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
			public _003CgenerateMonster_003Ed__23(int _003C_003E1__state)
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

		private const string LOG_TAG = "[SingleWaveController]";

		private float waitBossTime;

		private Vector3 deltaOffset;

		private bool isMonstersFinished;

		private WavesController wavesController;

		private SingleWaveVO waveVO;

		private List<SingleWavePosVO> AllBirthPosVOs;

		private List<int> monsterCounts;

		private List<Tuple<int, int, int>> monsterInfoList;

		private List<int> availableMonsterIds;

		private string randomBirthIdStr;

		private Coroutine generateCoroutine;

		public bool IsMonstersFinished => false;

		public int SubWaveCount => 0;

		public SingleWaveController(WavesController _controller)
		{
		}

		public void DeInit()
		{
		}

		public void StartWave(SingleWaveVO _vo)
		{
		}

		private void refreshMonsterInfoList()
		{
		}

		private void refreshAvailableMonsterIds()
		{
		}

		private void refreshAllBirthPos()
		{
		}

		private bool checkIfElite()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CgenerateMonster_003Ed__23))]
		private IEnumerator generateMonster()
		{
			return null;
		}

		private EntityCallBase createMonsterByGood(int monsterId, Vector2Int xy, bool isElite)
		{
			return null;
		}

		private void createSingleMonster(EntityBase monster)
		{
		}

		private void clear()
		{
		}

		private string getInfo()
		{
			return null;
		}

		private void initMonsterCounts()
		{
		}

		private int GetMonsterPerWaveBydifficulty(int source)
		{
			return 0;
		}

		private string getRandomBirthId(string[] waveIDs)
		{
			return null;
		}

		private void log(string info)
		{
		}

		private void logError(string errInfo)
		{
		}
	}
}
