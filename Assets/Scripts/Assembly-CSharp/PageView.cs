using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PageView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	private ScrollRect rect;

	private float targethorizontal;

	private bool isDrag;

	private List<float> posList;

	private int currentPageIndex;

	public Action<int> OnPageChanged;

	private bool stopMove;

	public float smooting;

	public float sensitivity;

	private float startTime;

	private float startDragHorizontal;

	public void Awaker()
	{
	}

	private void Update()
	{
	}

	public void pageTo(int index)
	{
	}

	private void SetPageIndex(int index)
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public int GetCurrentIndex()
	{
		return 0;
	}
}
