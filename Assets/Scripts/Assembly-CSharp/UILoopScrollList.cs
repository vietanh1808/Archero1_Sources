using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILoopScrollList : MonoBehaviour
{
	private enum ContentPivot
	{
		Left = 0,
		Right = 1,
		Bottom = 2,
		Top = 3
	}

	public float verticalOffset;

	public float horizonOffset;

	public MonoBehaviour copyItem;

	public float itemWidth;

	public float itemHeight;

	public int verticalSpace;

	public int horizonSpace;

	public int rowCount;

	public int createCountPerframe;

	public ScrollRect scroll;

	public Action OnScrollEnd;

	private Queue<UILoopScrollList_Item> cacheQueue;

	private Dictionary<int, UILoopScrollList_Item> showItemDic;

	private int verticalIndex;

	private int horizonIndex;

	private int verticalCountPerContent;

	private int horizonCountPerContent;

	private object[] dataList;

	private ContentPivot pivot;

	private bool isInit;

	private bool isDataChange;

	private Dictionary<int, object> itemBlackBoardData;

	private Vector2 scrollStart;

	private Vector2 scrollEnd;

	private float scrollTime;

	private float tickTime;

	private bool isScrolling;

	public void SetBlackBoardData(int index, object data)
	{
	}

	public object GetBlackBoardData(int index)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void Init()
	{
	}

	public void Refresh(object[] dataArray, int index = -1, float offset = 0f, bool isPlayAnim = false, float scrollTime = 0f)
	{
	}

	private void RecycleAll()
	{
	}

	public void ScrollTo(int index, float offset, bool isPlayAnim = false, float time = 0f)
	{
	}

	private void UpdateContent()
	{
	}

	private UILoopScrollList_Item GetItem()
	{
		return null;
	}

	private Vector2 GetPosByIndex(int index)
	{
		return default;
	}

	private void RecycleItem(int curStartIndex, int curEndIndex, int start, int end)
	{
	}

	private void OnValueChange(Vector2 delta)
	{
	}

	public bool IsScrolling()
	{
		return false;
	}
}
