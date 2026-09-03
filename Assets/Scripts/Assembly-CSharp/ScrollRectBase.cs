using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollRectBase : ScrollRect, IPointerClickHandler, IEventSystemHandler
{
	public Action<PointerEventData> BeginDrag;

	public Action<PointerEventData> Drag;

	public Action<PointerEventData> EndDrag;

	public Action OnClick;

	public Action<int> EndDragItem;

	public Action<Vector2> ValueChanged;

	public Action OnUpdateWholeEnd;

	private float scrollpercent;

	public bool UseWhole;

	private bool _usegrag;

	public bool DragDisableForce;

	public bool bUseScrollEvent;

	public float SpeedCritical;

	public float Whole_PerOne;

	public int Whole_Count;

	public float AllWidth;

	private bool _dragging;

	private bool _sendfinish;

	private bool bUpdateEnd;

	private float speed;

	private int currentPage;

	private float scrollendpos;

	private Action mPageAniFinish;

	private bool[] mLocks;

	private bool bGotoStart;

	private float mGotoValue;

	private float mGotoTemp;

	public bool UseDrag
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool bDragging
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool bSendFinish
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	public void RemoveAllListeners()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void SetLocks(bool[] locks)
	{
	}

	private int GetNextUnlock(int currentindex, bool left)
	{
		return 0;
	}

	private void OnUpdateGoto()
	{
	}

	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnBeginDragInternal(PointerEventData eventData)
	{
	}

	public override void OnDrag(PointerEventData eventData)
	{
	}

	public void OnDragInternal(PointerEventData eventData)
	{
	}

	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnEndDragInternal(PointerEventData eventData)
	{
	}

	private void OnValueChanged(Vector2 value)
	{
	}

	public void Goto(float value, bool playanimation = false)
	{
	}

	private void OnEnableWhole()
	{
	}

	private void OnDisableWhole()
	{
	}

	public void SetWhole(GridLayoutGroup grid, int count)
	{
	}

	public void SetPage(int page, bool animate, Action onFinish = null)
	{
	}

	private void OnBeginDragWhole(PointerEventData eventData)
	{
	}

	private void OnDragWhole(PointerEventData eventData)
	{
	}

	private void OnEndDragWhole(PointerEventData eventData)
	{
	}

	private void UpdateScrollEndPos()
	{
	}

	private void OnUpdateWhole()
	{
	}

	private int GetPage()
	{
		return 0;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
