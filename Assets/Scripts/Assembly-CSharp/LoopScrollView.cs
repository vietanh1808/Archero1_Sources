using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LoopScrollView : MonoBehaviour
{
	public class SegmentData
	{
		public int index;

		public string lanKey;

		public List<object> m_listDatas;

		public Func<int, string, GameObject> OnCreateSegment;

		private GameObject m_segment;

		public float m_fSegmentHeight;

		public bool m_bNewLine;

		public int m_nOffsetIndex;

		public int Cnt => 0;

		public GameObject Segment => null;

		public object this[int index] => null;

		public void Clear()
		{
		}
	}

	public enum SCROLL_TYPE
	{
		SCROLL_TYPE_Vertical = 0,
		SCROLL_TYPE_Horizontal = 1
	}

	private enum SCROLL_DIR
	{
		SCROLL_DIR_None = 0,
		SCROLL_DIR_Up = 1,
		SCROLL_DIR_Down = 2,
		SCROLL_DIR_Left = 3,
		SCROLL_DIR_Right = 4
	}

	[CompilerGenerated]
	private sealed class _003CInitScrollView_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoopScrollView _003C_003E4__this;

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
		public _003CInitScrollView_003Ed__38(int _003C_003E1__state)
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

	private const string Tag = "LoopScrollView";

	protected RectTransform Content;

	protected RectTransform Mask;

	[Header("Item预制体")]
	public GameObject CopyItem;

	[Header("预留底部空间")]
	public float BottomPadding;

	[Header("预留头部空间")]
	public float TopPadding;

	[Header("预留左边空间")]
	public float LeftPadding;

	[Header("预留右边空间")]
	public float RightPadding;

	[Header("Item大小")]
	public Vector2 ItemSize;

	[Header("遮罩大小")]
	protected Vector2 MaskSize;

	[Header("水平列表还是垂直列表")]
	public SCROLL_TYPE ScrollType;

	public bool bUpdateWear;

	private SCROLL_DIR Scroll_Dir;

	[Header("是否自动水平布局")]
	public bool AutoHorizontalLayout;

	[Header("列间距")]
	public float Horizontal_Space;

	[Header("是否自动垂直布局")]
	public bool AutoVerticalLayout;

	[Header("行间距")]
	public float Vertical_Space;

	private Queue<GameObject> m_queueForwardItems;

	private Queue<GameObject> m_queueReverseItems;

	private List<SegmentData> m_listDatas;

	private int m_nDataCount;

	private int m_nRenderIndex;

	private int m_nRenderCount;

	private int m_nLastRowOrCollomnIndex;

	private int m_nColumnCount;

	private float m_fLastOffset;

	private Action<object> OnClickItem;

	private Action<int, RectTransform> OnCreateItem;

	private LocalUnityObjctPool ItemPool;

	private void Awake()
	{
	}

	private bool CheckNewLine(int index, out SegmentData data, out float fSegmentTotalHeight)
	{
		data = null;
		fSegmentTotalHeight = default;
		return false;
	}

	private object GetData(int index)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public virtual void Init(SegmentData data, Action<object> OnClickAction, Action<int, RectTransform> OnCreateAction)
	{
	}

	public void AddData(SegmentData data)
	{
	}

	[IteratorStateMachine(typeof(_003CInitScrollView_003Ed__38))]
	private IEnumerator InitScrollView()
	{
		return null;
	}

	protected virtual void calculateMaskSize()
	{
	}

	private GameObject CreateItem(int index)
	{
		return null;
	}

	protected virtual GameObject CreateNewItem()
	{
		return null;
	}

	private bool calculateRect(ref Rect totalRect)
	{
		return false;
	}

	private void onScrollRectValueChanged(Vector2 v)
	{
	}

	private void onVerticalScroll()
	{
	}

	private void onScrollUp(int index)
	{
	}

	private void createNewLine()
	{
	}

	private void onScrollDown(int index)
	{
	}

	private void addDataToQueue(bool toReverse)
	{
	}

	private void calculateDir()
	{
	}

	private void ClearScrollView()
	{
	}

	public virtual void OnClose()
	{
	}

	protected virtual void ClearItems()
	{
	}
}
