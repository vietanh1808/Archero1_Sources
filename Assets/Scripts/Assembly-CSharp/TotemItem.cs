using System;
using UnityEngine;

public class TotemItem : MonoBehaviour
{
	public DxxImage icon;

	public DxxImage bgIcon;

	public ButtonCtrl btnClick;

	public DxxImage outSelectIcon;

	public DxxImage insideSelectIcon;

	public DxxText txtLevel;

	[SerializeField]
	private GameObject refineLevelRoot;

	[SerializeField]
	private GameObject refineNormalFrame;

	[SerializeField]
	private GameObject refineMaxFrame;

	[SerializeField]
	private DxxText refineLevelText;

	public TotemItemData itemData;

	public void Init(TotemItemData data, Action<TotemItemData> clickCallback)
	{
	}

	public void SetSelectStatus(long selectRowID, bool isInside = false)
	{
	}

	public void SetMultSelectStatus(long selectRowID, bool isInside = false)
	{
	}

	public void SetSelectStatus(int rare, bool isSelected, bool isInside = false)
	{
	}

	public void SetBgShow(bool isShow)
	{
	}

	public void SetLevelShow(bool isShow)
	{
	}

	private void RefreshLevelState(TotemItemData data)
	{
	}
}
