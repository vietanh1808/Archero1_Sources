using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Dxx.UI
{
	public class InfinityScrollGroup : UIBehaviour, ILayoutElement
	{
		protected interface ComponentAction
		{
			void Invoke(int index, Component component);
		}

		protected class ChildComponentAction<T> : ComponentAction where T : Component
		{
			public Action<int, T> callBack;

			public ChildComponentAction(Action<int, T> callBack)
			{
			}

			public void Invoke(int index, Component component)
			{
			}
		}

		public enum Axis
		{
			Horizontal = 0,
			Vertical = 1
		}

		[CompilerGenerated]
		private sealed class _003CScrollToItemImpl_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InfinityScrollGroup _003C_003E4__this;

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
			public _003CScrollToItemImpl_003Ed__43(int _003C_003E1__state)
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

		[Header("<Infinity>")]
		[AliasName("子物体", true)]
		[Tooltip("复制用子物体.")]
		public GameObject copyItemChild;

		[AliasName("数据个数", true)]
		[Tooltip("数据个数.必须大于0")]
		public int itemCount;

		public ScrollRect scrollRect;

		[Header("<Layout>")]
		public RectOffset padding;

		public Vector2 cellSize;

		public Vector2 spacing;

		public Axis sortAxis;

		[Tooltip("必须大于1")]
		public int constraintCount;

		[Header("滚动最小长度，0为不限制")]
		public float MinScrollLength;

		protected Action<int, GameObject> updateChildCallBack;

		protected Dictionary<Type, ComponentAction> updateChildComponentCallBack;

		public Action<Vector2> onSizeChange;

		protected List<RectTransform> rectChildren;

		protected Dictionary<GameObject, Component[]> objToCompnent;

		protected DrivenRectTransformTracker m_Tracker;

		private int lastRowIndex;

		[NonSerialized]
		private RectTransform m_Rect;

		private List<GameObject> childCache;

		private Vector2 m_TotalMinSize;

		private Vector2 m_TotalPreferredSize;

		private Vector2 m_TotalFlexibleSize;

		public int displayItemCount => 0;

		public int displayMaxRow => 0;

		public int itemMaxRow => 0;

		public RectTransform rectTransform => null;

		public virtual float minWidth => 0f;

		public virtual float preferredWidth => 0f;

		public virtual float flexibleWidth => 0f;

		public virtual float minHeight => 0f;

		public virtual float preferredHeight => 0f;

		public virtual float flexibleHeight => 0f;

		public virtual int layoutPriority => 0;

		protected override void Awake()
		{
		}

		public void Init(int displayCount, int itemCount, GameObject copyItemChild = null)
		{
		}

		public void RefreshAll()
		{
		}

		private void UpdateChildListCallback(int index, GameObject obj)
		{
		}

		public void RegUpdateCallback(Action<int, GameObject> callBack)
		{
		}

		public void UnRegUpdateCallback(Action<int, GameObject> callBack)
		{
		}

		public void RegUpdateCallback<T>(Action<int, T> callBack) where T : Component
		{
		}

		public void UnRegUpdateCallback<T>(Action<int, T> callBack) where T : Component
		{
		}

		private void UpdateLayout()
		{
		}

		private void UpdateLayoutChildren(bool callUpdate = true, bool callUpdateAlways = false)
		{
		}

		private void UpdateLayoutContent()
		{
		}

		private int PositionToRealIndex(Vector2 pos)
		{
			return 0;
		}

		private Vector2Int PositionToGrid(Vector2 pos)
		{
			return default;
		}

		private float ContentPositionToRowIndex(Vector2 pos)
		{
			return 0f;
		}

		public void ScrollToItem(int itemIndex)
		{
		}

		[IteratorStateMachine(typeof(_003CScrollToItemImpl_003Ed__43))]
		private IEnumerator ScrollToItemImpl()
		{
			return null;
		}

		private void ScrollChild(int indexCount)
		{
		}

		protected void Scroll(Vector2 value)
		{
		}

		private void DestroyChild(RectTransform child)
		{
		}

		private void CreateNewDisplayChild()
		{
		}

		private void SetDisplayCount(int newCount)
		{
		}

		public void SetItemCount(int newCount, bool callUpdate = true)
		{
		}

		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		public virtual void CalculateLayoutInputVertical()
		{
		}

		protected float GetTotalMinSize(int axis)
		{
			return 0f;
		}

		protected float GetTotalPreferredSize(int axis)
		{
			return 0f;
		}

		protected float GetTotalFlexibleSize(int axis)
		{
			return 0f;
		}

		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
		{
		}
	}
}
