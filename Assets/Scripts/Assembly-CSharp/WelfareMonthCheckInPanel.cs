using System.Collections.Generic;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class WelfareMonthCheckInPanel : MonoBehaviour
{
	public DxxText titleTex;

	public ButtonCtrl closeBtn;

	public Button bgBtn;

	public WelfareMonthCheckInItem copyObj;

	public RectTransform itemParent;

	public RectTransform view;

	private List<WelfareMonthCheckInItem> items;

	private STActivityCrazyMonth mData;

	public void Init(STActivityCrazyMonth month)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void RefreshList()
	{
	}

	private void JumpTo()
	{
	}

	public STActivityCrazyTask GetData(uint type, uint taskId)
	{
		return null;
	}

	public void RefreshTask()
	{
	}
}
