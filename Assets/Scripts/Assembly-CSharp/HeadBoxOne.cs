using System;
using UnityEngine;
using UnityEngine.UI;

public class HeadBoxOne : MonoBehaviour
{
	public enum TabName
	{
		Unknown = 0,
		Player = 1
	}

	public GameObject focus;

	public Image circle;

	public GameObject locker;

	public ButtonCtrl button;

	public RedNodeCtrl redNodeCtrl;

	public Action<HeadBoxOne> OnButtonClick;

	private int headFrameId;

	private int index;

	private TabName tabName;

	private bool haveRed;

	private GameObject _effect;

	private RectTransform _scrollViewRect;

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected void Awake()
	{
	}

	public void initHeadFrame(int headFrameId, RectTransform scrollViewRect, int index = -1, TabName tabName = TabName.Unknown)
	{
	}

	public void setFocus(bool show)
	{
	}

	public void cancelEnterFocusRed()
	{
	}

	private void Update()
	{
	}
}
