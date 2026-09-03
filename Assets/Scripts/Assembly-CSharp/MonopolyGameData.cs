using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameProtocol;
using TableTool;
using UnityEngine;

public class MonopolyGameData
{
	public enum ChessGridType
	{
		None = 0,
		Start = 1,
		Reward = 2,
		MinecartStart = 3,
		MinecartEnd = 4,
		Railway = 5,
		NianBeast = 6,
		SlotMachines = 7,
		Prison = 8
	}

	public enum ChessGridEvent
	{
		None = 0,
		MinecartEnd = 1,
		TiggerFire = 2
	}

	public class PieceData
	{
		[CompilerGenerated]
		private sealed class _003CJump_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PieceData _003C_003E4__this;

			public ChessGridData[] path;

			private WaitForSeconds _003Cwait_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CJump_003Ed__14(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CRailway_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PieceData _003C_003E4__this;

			public ChessGridData[] path;

			private WaitForSeconds _003Cwait_003E5__2;

			private WaitForSeconds _003Cwait2_003E5__3;

			private int _003Ci_003E5__4;

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
			public _003CRailway_003Ed__20(int _003C_003E1__state)
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

		public float OneGridDuration;

		public float ReadyJumpDuration;

		public float EndJumpDuration;

		public Action<ChessGridData, bool> OnToPostion;

		public Action<ChessGridData, bool> OnPassPosition;

		public Action<ChessGridData> OnEndJump;

		public Action OnStartJump;

		public Func<ChessGridData, bool, IEnumerator> CheckCompletePass;

		public float OneRailwayGridDuration;

		public float ReadyRailwayDuration;

		public float EndRailwayDuration;

		public Action<ChessGridData> OnEndRailway;

		public Action OnStartRailway;

		public int position { get; private set; }

		public void SetPostion(int pos)
		{
		}

		public void ToPosition(ChessGridData grid, bool isLast = false)
		{
		}

		[IteratorStateMachine(typeof(_003CJump_003Ed__14))]
		public IEnumerator Jump(ChessGridData[] path)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRailway_003Ed__20))]
		public IEnumerator Railway(ChessGridData[] path)
		{
			return null;
		}
	}

	public class ChessGridData
	{
		private MonopolyManager.TileConfig Config;

		public Action<ChessGridData> OnPassCallback;

		public Action<ChessGridData> OnArriveCallback;

		public Action<ChessGridData> OnRefreshDataCallback;

		public Action<ChessGridEvent, object> OnEventDo;

		public ChessGridType GridType => ChessGridType.None;

		public int Position => 0;

		public int GridDesign => 0;

		public int[][] Rewards => null;

		public void OnPass()
		{
		}

		public void OnArrive()
		{
		}

		public void RefreshData(MonopolyManager.TileConfig config)
		{
		}

		public void OnEvent(ChessGridEvent EventName, object para = null)
		{
		}
	}

	public class ChessBoardData
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			public NetBox net;

			public int ratio;

			public int fixDice;

			internal bool _003CStartJump_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			public NetBox net;

			internal bool _003CStartPrisonDice_003Eb__1()
			{
				return false;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003C_003Ec__DisplayClass29_0
		{
			public MonopolySaveData data;

			public ChessGridData[] path;

			public int ratio;

			public int stepCount;
		}

		[CompilerGenerated]
		private sealed class _003CCheckCompleteJump_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChessBoardData _003C_003E4__this;

			public MonopolySaveData data;

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
			public _003CCheckCompleteJump_003Ed__38(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCheckCompletePass_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChessGridData grid;

			public bool isLast;

			public ChessBoardData _003C_003E4__this;

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
			public _003CCheckCompletePass_003Ed__35(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCheckOpenPanel_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChessBoardData _003C_003E4__this;

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
			public _003CCheckOpenPanel_003Ed__28(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CJump_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MonopolySaveData data;

			public int ratio;

			public int stepCount;

			public ChessBoardData _003C_003E4__this;

			private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

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
			public _003CJump_003Ed__29(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CRailway_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChessBoardData _003C_003E4__this;

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
			public _003CRailway_003Ed__31(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CRefreshData_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChessBoardData _003C_003E4__this;

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
			public _003CRefreshData_003Ed__34(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CStartJump_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int ratio;

			public int fixDice;

			private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

			public ChessBoardData _003C_003E4__this;

			private STRespActivityMonopoly _003Cdata_003E5__2;

			private MonopolySaveData _003CsaveData_003E5__3;

			private Drop_DropModel.DropData _003CdiceDrop_003E5__4;

			private int _003Cstep_003E5__5;

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
			public _003CStartJump_003Ed__24(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CStartPrisonDice_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

			public ChessBoardData _003C_003E4__this;

			private STRespActivityMonopoly _003Cdata_003E5__2;

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
			public _003CStartPrisonDice_003Ed__27(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CTriggerNianBeast_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChessBoardData _003C_003E4__this;

			public MonopolySaveData data;

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
			public _003CTriggerNianBeast_003Ed__42(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CTriggerNianBeastOnOpen_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int FinalSorce;

			public ChessBoardData _003C_003E4__this;

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
			public _003CTriggerNianBeastOnOpen_003Ed__43(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CTriggerPrison_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChessBoardData _003C_003E4__this;

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
			public _003CTriggerPrison_003Ed__40(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CTriggerSlotMachines_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChessBoardData _003C_003E4__this;

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
			public _003CTriggerSlotMachines_003Ed__45(int _003C_003E1__state)
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

		public Vector2 FirstGridPos;

		public float offsetX;

		public float offsetY;

		public Dictionary<int, Vector2> Nodes;

		public Vector2 RailwayDir;

		public int MaxPostion;

		public int ExtraGridCount;

		public Func<int, int, IEnumerator> OnStartDice;

		public Func<int, int, IEnumerator> OnStartPrisonDice;

		public Func<List<Drop_DropModel.DropData>, IEnumerator> OnEndPrisonDice;

		public bool isRailwaying;

		public Func<IEnumerator> OnRefreshChessBoard;

		private bool isRefreshing;

		public Func<MonopolySaveData, IEnumerator> OnTriggerReward;

		public Action<bool> OnAfterJump;

		public Func<IEnumerator> OnTriggerPrison;

		public Func<MonopolySaveData, IEnumerator> OnTriggerNianBeast;

		public Func<IEnumerator> OnTriggerSlotMachines;

		public Vector2 FirstRailwayGridPos => default;

		public PieceData PieceData { get; private set; }

		public ChessGridData[] chessGridDatas { get; private set; }

		public STActivityMonopolyCore activityMonopolyCore { get; set; }

		public void Init(STActivityMonopolyCore coreData)
		{
		}

		[IteratorStateMachine(typeof(_003CStartJump_003Ed__24))]
		public IEnumerator StartJump(int ratio, int fixDice = 0)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CStartPrisonDice_003Ed__27))]
		public IEnumerator StartPrisonDice()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCheckOpenPanel_003Ed__28))]
		public IEnumerator CheckOpenPanel()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CJump_003Ed__29))]
		private IEnumerator Jump(int stepCount, MonopolySaveData data, int ratio)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRailway_003Ed__31))]
		private IEnumerator Railway()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRefreshData_003Ed__34))]
		private IEnumerator RefreshData()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCheckCompletePass_003Ed__35))]
		private IEnumerator CheckCompletePass(ChessGridData grid, bool isLast)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCheckCompleteJump_003Ed__38))]
		private IEnumerator CheckCompleteJump(MonopolySaveData data)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTriggerPrison_003Ed__40))]
		private IEnumerator TriggerPrison()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTriggerNianBeast_003Ed__42))]
		private IEnumerator TriggerNianBeast(MonopolySaveData data)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTriggerNianBeastOnOpen_003Ed__43))]
		private IEnumerator TriggerNianBeastOnOpen(int FinalSorce)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTriggerSlotMachines_003Ed__45))]
		private IEnumerator TriggerSlotMachines()
		{
			return null;
		}

		public ChessGridData GetGridDataByType(ChessGridType gridType)
		{
			return null;
		}

		public ChessGridData GetGridDataByIndex(int index)
		{
			return null;
		}
	}

	public const string MonopolySaveDataKey = "MonopolySaveData";

	private ChessBoardData chessBoard;

	public long LeftTime => 0L;

	public ChessBoardData GetChessBoard()
	{
		return null;
	}

	public void RefreshChessBoard(STActivityMonopolyCore coreData)
	{
	}
}
