using UnityEngine;
using UnityEngine.UI;

public class MainDownCtrl : MonoBehaviour
{
	private const int PageCount = 5;

	private GameObject[] locksimage;

	private GameObject[] images;

	private ButtonCtrl[] buttons;

	private Text[] texts;

	private bool[] locks;

	private RedNodeCtrl[] mReds;

	private ScrollRectBase mScrollRect;

	private Transform bottomline;

	private bool bInit;

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

	private bool get_lock_condition_talent()
	{
		return false;
	}

	private bool GetLockConditionDaily()
	{
		return false;
	}

	public bool GetLock(int index)
	{
		return false;
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

	private void OnDestroy()
	{
	}
}
