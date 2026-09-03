using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImprintPartItem : MonoBehaviour
{
	public DxxText Text_Title;

	public ImprintItem item;

	public Image m_Bg;

	public RectTransform mItemParent;

	public GameObject mMask;

	private float firstx;

	private float firsty;

	private float spacex;

	private float spacey;

	public int columns;

	private IEnumerable<LocalSave.ImprintOne> list;

	private List<LocalSave.ImprintOne> list2;

	private int rare;

	public void Init(int rare)
	{
	}

	private void RefreshTitle()
	{
	}

	private string GetColorByRare(int rare)
	{
		return null;
	}

	public void DeInit()
	{
	}

	public void RefreshRed()
	{
	}

	public void RefreshMask(int seatId)
	{
	}

	public void RefreshItemsPositon()
	{
	}

	public float GetHeight()
	{
		return 0f;
	}

	private void OnDestroy()
	{
	}
}
