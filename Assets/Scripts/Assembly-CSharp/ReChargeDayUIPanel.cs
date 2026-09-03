using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class ReChargeDayUIPanel : MonoBehaviour
{
	private DxxText Text_Time;

	public RechargeDayItem itemCopy;

	private List<RechargeDayItem> RewardList;

	public Transform itemParent;

	private long showTimex;

	public ButtonCtrl tipButton;

	public DxxText descText1;

	public DxxText descText2;

	public GameObject popTips;

	public DxxText popTitle;

	public DxxText popContent;

	public ButtonCtrl popCloseBtn;

	private bool isOpen;

	private string timeDownKey;

	public void Init(DxxText textTime)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	private void RefreshTime()
	{
	}

	private void UpdateTime()
	{
	}

	public void Refresh()
	{
	}
}
