using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UIKit
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(ScrollRect))]
	public class UITableView : UIBehaviour
	{
		private readonly struct Range
		{
			public int from { get; }

			public int to { get; }

			public Range(int from, int to)
			{
				this.from = 0;
				this.to = 0;
			}
		}

		private class UITableViewCellHolder
		{
			public UITableViewCell loadedCell { get; set; }

			public float scalar { get; set; }

			public float upperMargin { get; set; }

			public float lowerMargin { get; set; }

			public float position { get; set; }
		}

		[CompilerGenerated]
		private sealed class _003CAutoScroll_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UITableViewCellLocation location;

			public UITableView _003C_003E4__this;

			public float time;

			public Action onScrollingFinished;

			private Vector2 _003Cfrom_003E5__2;

			private Vector2 _003Cto_003E5__3;

			private float _003CstartAt_003E5__4;

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
			public _003CAutoScroll_003Ed__66(int _003C_003E1__state)
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
		private sealed class _003CGetAllLoadedCells_003Ed__83 : IEnumerable<UITableViewCell>, IEnumerable, IEnumerator<UITableViewCell>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private UITableViewCell _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public UITableView _003C_003E4__this;

			private Dictionary<int, UITableViewCellHolder>.Enumerator _003C_003E7__wrap1;

			UITableViewCell IEnumerator<UITableViewCell>.Current
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
			public _003CGetAllLoadedCells_003Ed__83(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<UITableViewCell> IEnumerable<UITableViewCell>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public const float DEFAULT_REACHABLE_EDGE_TOLERANCE = 0.1f;

		private int _numberOfCellsAtRowOrColumn;

		private UITableViewCellAlignment _cellAlignment;

		private readonly List<UITableViewCellHolder> _holders;

		private readonly Dictionary<string, Queue<UITableViewCell>> _reusableCellQueues;

		private readonly Dictionary<int, UITableViewCellHolder> _loadedHolders;

		private readonly List<int> _swapper;

		private Transform _cellsPool;

		private Coroutine _autoScroll;

		private bool _isReloaded;

		private Vector2 _normalizedPositionWhenReloaded;

		private bool _isReachingBottommostOrLeftmost;

		private bool _isReachingTopmostOrRightmost;

		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private RectTransform _viewport;

		[SerializeField]
		private RectTransform _content;

		[SerializeField]
		private UITableViewDirection _direction;

		[SerializeField]
		private bool _ignoreCellLifeCycle;

		[SerializeField]
		public new int tag;

		public ScrollRect scrollRect => null;

		public IUITableViewDataSource dataSource { get; set; }

		public IUITableViewMargin marginDataSource { get; set; }

		public IUITableViewDelegate @delegate { get; set; }

		public IUITableViewReachable reachable { get; set; }

		public bool ignoreCellLifeCycle
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public UITableViewDirection direction
		{
			get
			{
				return UITableViewDirection.TopToBottom;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected void Update()
		{
		}

		private void InitializeScrollRect()
		{
		}

		private void InitializeCellsPool()
		{
		}

		private void Validate()
		{
		}

		private Range RecalculateVisibleRange(Vector2 normalizedPosition)
		{
			return default;
		}

		private int FindIndexOfCellAtPosition(float position)
		{
			return 0;
		}

		private int FindIndexOfCellAtPosition(float position, int startIndex, int length)
		{
			return 0;
		}

		private void ResizeContent(int numberOfCells)
		{
		}

		private void OnScrollPositionChanged(Vector2 normalizedPosition)
		{
		}

		private void ReloadCells(Vector2 normalizedPosition, bool alwaysRearrangeCell)
		{
		}

		private void LoadCells(Range range, bool alwaysRearrangeCell)
		{
		}

		private void LoadCell(int index, bool alwaysRearrangeCell)
		{
		}

		private void UnloadUnusedCells(Range visibleRange)
		{
		}

		private void UnloadAllCells()
		{
		}

		private void UnloadCell(int index)
		{
		}

		private void RearrangeCell(int index)
		{
		}

		private void ReloadDataInternal(UITableViewCellLocation? startLocation, Vector2? startNormalizedPosition)
		{
		}

		private void DetectAndNotifyReachableStatus(Vector2 normalizedPosition)
		{
		}

		private void CalculateReachableStatus(Vector2 normalizedPosition, out bool isReachingTopmostOrRightmost, out bool isReachingBottommostOrLeftmost)
		{
			isReachingTopmostOrRightmost = default;
			isReachingBottommostOrLeftmost = default;
		}

		private void StopAutoScroll(Action onScrollingFinished)
		{
		}

		private void StartAutoScroll(UITableViewCellLocation location, float time, Action onScrollingFinished)
		{
		}

		[IteratorStateMachine(typeof(_003CAutoScroll_003Ed__66))]
		private IEnumerator AutoScroll(UITableViewCellLocation location, float time, Action onScrollingFinished)
		{
			return null;
		}

		public void RearrangeData()
		{
		}

		public void UnloadData()
		{
		}

		public void ReloadDataAt(int index)
		{
		}

		public void ReloadData(int startIndex, UITableViewCellAlignment alignment = UITableViewCellAlignment.RightOrTop, bool withMargin = false, float displacement = 0f)
		{
		}

		public void ReloadData(UITableViewCellLocation location)
		{
		}

		public void ReloadData(Vector2 normalizedPosition)
		{
		}

		public void ReloadData()
		{
		}

		public void AppendData()
		{
		}

		public void PrependData()
		{
		}

		public T ReuseOrCreateCell<T>(T prefab, UITableViewCellLifeCycle lifeCycle = UITableViewCellLifeCycle.RecycleWhenDisappeared, bool isAutoResize = true) where T : UITableViewCell
		{
			return null;
		}

		public void ScrollToCellAt(int index, float time, UITableViewCellAlignment alignment = UITableViewCellAlignment.RightOrTop, bool withMargin = false, float displacement = 0f, Action onScrollingFinished = null)
		{
		}

		public void ScrollToCellAt(UITableViewCellLocation location, float time, Action onScrollingFinished)
		{
		}

		public void ScrollToCellAt(int index, UITableViewCellAlignment alignment = UITableViewCellAlignment.RightOrTop, bool withMargin = false, float displacement = 0f)
		{
		}

		public void ScrollToCellAt(UITableViewCellLocation location)
		{
		}

		public Vector2 GetNormalizedPositionOfCellAt(UITableViewCellLocation location)
		{
			return default;
		}

		public T GetLoadedCell<T>(int index) where T : UITableViewCell
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetAllLoadedCells_003Ed__83))]
		public IEnumerable<UITableViewCell> GetAllLoadedCells()
		{
			return null;
		}

		public void RefreshAllLoadedCells()
		{
		}

		public void DestroyCachedReusableCells()
		{
		}
	}
}
