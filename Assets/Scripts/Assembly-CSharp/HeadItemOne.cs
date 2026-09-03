using System;
using UnityEngine;
using UnityEngine.UI;

public class HeadItemOne : MonoBehaviour
{
	public enum TabName
	{
		Unknown = 0,
		Player = 1,
		Rank = 2,
		Main = 3
	}

	public GameObject focus;

	public Image face;

	public Image circle;

	public GameObject locker;

	public ButtonCtrl button;

	public Material grayMaterial;

	public RedNodeCtrl redNodeCtrl;

	private Action<HeadItemOne> OnButtonClick;

	private int index;

	private TabName tabName;

	private int headId;

	private int headFrameId;

	private bool haveRed;

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

	private void Awake()
	{
	}

	public void initHead(int headId, int headFrameId, int index = -1, TabName name = TabName.Unknown)
	{
	}

	public void InitHeadByPlayerHomePage(int headId, int headFrameId, int index = -1, TabName name = TabName.Unknown)
	{
	}

	public void cancelEnterFocusRed()
	{
	}

	public void setButtonCallback(Action<HeadItemOne> callback)
	{
	}

	public void setLocker(bool unlock)
	{
	}

	public void setFocus(bool show)
	{
	}

	public void resetHead(int headId)
	{
	}

	public void resetHeadFrame(int headFrameId)
	{
	}

	private void UpdateEffect()
	{
	}

	public void Close()
	{
	}
}
