using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollIntCtrl<T> : ScrollRectBase where T : Component
{
	public class ScrollData
	{
		public float maxScale;

		public float minScale;

		public T one;

		public RectTransform transform;

		public int index;

		public float normalize;

		public float normalize_range;

		private float scale;

		private float scalex;

		public ScrollData(int index, T one)
		{
		}

		public void Refresh(int index, T one)
		{
		}

		public void Miss()
		{
		}

		public float UpdateScale(float normalizepos)
		{
			return 0f;
		}

		public void SetFront()
		{
		}
	}

	public GameObject copyItem;

	public Transform mScrollChild;

	[Header("滚动加速系数")]
	public float Speed;

	public Action<int, T> OnUpdateOne;

	public Action<int, T> OnUpdateSize;

	public Action<int, T> OnScrollEnd;

	public Action OnBeginDragEvent;

	public float maxScale;

	public float minScale;

	private bool bInit;

	private int showCount;

	private int count;

	private float allWidth;

	private float itemWidth;

	private float offsetx;

	private float lastscrollpos;

	private float lastspeed;

	private int mCurrentIndex;

	private LocalUnityObjctPool mObjPool;

	private List<ScrollData> mList;

	private Sequence seq;

	private int mGotoIntIndex;

	protected override void Awake()
	{
	}

	public void InitOnce()
	{
	}

	public void SetScale(float min, float max)
	{
	}

	public void SetShowCount(int showCount)
	{
	}

	public void Init(int count)
	{
	}

	private void UpdateOne(int i, T one)
	{
	}

	public void DeInit()
	{
	}

	private void OnDragBegin(PointerEventData eventData)
	{
	}

	private void OnDrags(PointerEventData eventData)
	{
	}

	private void OnDragEnd(PointerEventData eventData)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void UpdateScroll()
	{
	}

	private void UpdateSize()
	{
	}

	private void UpdateInfinity()
	{
	}

	public void GotoInt(int index, bool playanimation = false)
	{
	}
}
