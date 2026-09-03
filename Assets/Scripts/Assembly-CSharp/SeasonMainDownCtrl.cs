using UnityEngine;
using UnityEngine.UI;

public class SeasonMainDownCtrl : MonoBehaviour
{
	private const int PageCount = 4;

	private GameObject[] locksimage;

	private GameObject[] images;

	private ButtonCtrl[] buttons;

	private Text[] texts;

	private bool[] locks;

	private RedNodeCtrl[] mReds;

	private ScrollRectBase mScrollRect;

	private Transform bottomline;

	private bool bInit;

	public GameObject RedPoint_Shop;

	public GameObject RedPoint_Harvest;

	public GameObject RedPoint_Talent;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void init()
	{
	}

	public void SetScrollRect(ScrollRectBase scroll)
	{
	}

	public void UpdateUI()
	{
	}

	public void UpdateLock(int index)
	{
	}

	private void UpdateLock(int index, bool _lock)
	{
	}

	public bool GetLock(int index)
	{
		return false;
	}

	public void UpdateRedPoint()
	{
	}

	public void SetRedNodeType(int index, RedNodeType type)
	{
	}

	public void SetRedCount(int index, int count)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void checkSoulRedPoint()
	{
	}

	public void checkRedPoint_Talent()
	{
	}

	public void checkRedPoint_Shop()
	{
	}
}
