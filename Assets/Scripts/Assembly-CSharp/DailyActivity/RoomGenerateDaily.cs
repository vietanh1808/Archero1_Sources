using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;
using UnityEngine;

namespace DailyActivity
{
	public sealed class RoomGenerateDaily : RoomGenerateBase
	{
		[CompilerGenerated]
		private sealed class _003CDelayGameOver_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CDelayGameOver_003Ed__27(int _003C_003E1__state)
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

		private static readonly bool IF_TEST_DAILY;

		private LocalModelManager _tableMgr;

		private HoldManager _holdMgr;

		private ReleaseManager _releaseMgr;

		private BattleModuleData _battleData;

		private MapCreator _mapCreator;

		private GameModeBase _gameMode;

		private bool ifFirstEnter;

		private bool ifShowEventStrength;

		private Coroutine gameOverCo;

		private EntityArtifactBase artifactCenter;

		private ActionBasic m_action;

		public const string Line_a = "a";

		public const string Line_b = "b";

		public const string Line_c = "c";

		public const string Line_d = "d";

		private Dictionary<string, Daily_MazeMapConfig> m_dicConfigs;

		private int maxRoomIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int currentRoomIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void OnInit()
		{
		}

		private void setMaxRoomID()
		{
		}

		protected override void OnStartGame()
		{
		}

		protected override void OnStartGameEnd()
		{
		}

		private bool checkIfCreateNewPlay120NPC()
		{
			return false;
		}

		private void createNewPlay120NPC()
		{
		}

		private void createNewPlay121NPC()
		{
		}

		protected override bool OnIsBattleLoad()
		{
			return false;
		}

		protected override void OnEnterDoorBefore()
		{
		}

		protected override void OnEnterDoorAfter()
		{
		}

		protected override void ShowBossDeadEvent()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayGameOver_003Ed__27))]
		private IEnumerator DelayGameOver()
		{
			return null;
		}

		protected override string OnGetFirstRoomTMX()
		{
			return null;
		}

		protected override string OnGetTmxID(int roomid)
		{
			return null;
		}

		private string[] GetTmxIds(int roomid)
		{
			return null;
		}

		protected override bool gotonextdoor_canopen()
		{
			return false;
		}

		public bool CanOpenDoorInDaily125()
		{
			return false;
		}

		public bool CanOpenDoorInDaily126()
		{
			return false;
		}

		public override bool CanOpenDoor()
		{
			return false;
		}

		protected override void OnOpenDoor()
		{
		}

		private bool check_event_strength()
		{
			return false;
		}

		protected override void OnEventClose(EventCloseTransfer data)
		{
		}

		protected override void OnDeInit()
		{
		}

		public override bool IsLastRoom()
		{
			return false;
		}

		protected override void OnReceiveEvent(string eventName, object data)
		{
		}

		private bool isWaveRoom()
		{
			return false;
		}

		private bool ifShowGoldTurn()
		{
			return false;
		}

		private void showGoldTurn()
		{
		}

		private void refreshRoomCtrl()
		{
		}

		private bool bossDropShop()
		{
			return false;
		}

		protected override bool CheckShowDeadEvent()
		{
			return false;
		}

		protected override void SendSDKGameOverPoint()
		{
		}

		protected override void SetBattleInHeroPostion()
		{
		}

		protected override void GotoNextDoor()
		{
		}

		protected override void UnloadUnusedMap(Room room)
		{
		}

		protected override void SetAbsorb(bool enable)
		{
		}

		private void OnDailyGuildInit()
		{
		}

		private void OnDailyGuildDeInit()
		{
		}

		private void CreateGuildNpc()
		{
		}

		private void OnEventMiss()
		{
		}

		private void CreatePortals()
		{
		}

		public int GetPortalId(string line)
		{
			return 0;
		}

		public override void EnterPortalDoor(int line)
		{
		}

		protected override void RandomNextRoom()
		{
		}

		private void _RandomNextRoom()
		{
		}

		protected override string OnGetTmxID(int line, int roomid)
		{
			return null;
		}

		private string[] GetTmxIdsByLine(int line, int roomid)
		{
			return null;
		}
	}
}
