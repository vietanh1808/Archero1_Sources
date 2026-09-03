using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MonopolyChessBoard : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COnTriggerPrison_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003COnTriggerPrison_003Ed__23(int _003C_003E1__state)
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
	private sealed class _003COnTriggerSlotMachines_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003COnTriggerSlotMachines_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CRefreshChessBoard_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolyChessBoard _003C_003E4__this;

		private IEnumerator<IGrouping<float, MonopolyChessGrid>> _003C_003E7__wrap1;

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
		public _003CRefreshChessBoard_003Ed__19(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private MonopolyGameData.ChessBoardData mData;

	public MonopolyChessGrid copyGrid;

	public Transform gridParent;

	private List<MonopolyChessGrid> monopolyChessGrids;

	public MonopolyPiece piece;

	private IOrderedEnumerable<IGrouping<float, MonopolyChessGrid>> group;

	private Vector2 FirstGridPos => default;

	private Vector2 FirstRailwayGridPos => default;

	private float offsetX => 0f;

	private float offsetY => 0f;

	private Dictionary<int, Vector2> Nodes => null;

	private Vector2 RailwayDir => default;

	public void Init(MonopolyGameData.ChessBoardData data)
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshChessBoard_003Ed__19))]
	public IEnumerator RefreshChessBoard()
	{
		return null;
	}

	public void Open()
	{
	}

	private void OnRegistEvent()
	{
	}

	[IteratorStateMachine(typeof(_003COnTriggerSlotMachines_003Ed__22))]
	private IEnumerator OnTriggerSlotMachines()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnTriggerPrison_003Ed__23))]
	private IEnumerator OnTriggerPrison()
	{
		return null;
	}

	private void OnToPostion(MonopolyGameData.ChessGridData grid, bool isLast)
	{
	}

	private void OnUnRegistEvent()
	{
	}

	public void Close()
	{
	}
}
