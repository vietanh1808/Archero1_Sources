using System;
using PureMVC.Interfaces;
using UnityEngine;

public class Act6thActBtn : MonoBehaviour
{
	public int actIndex;

	public DxxText nameTex;

	public DxxText timeText;

	public ButtonCtrl clickBtn;

	public GameObject goRed;

	public static Act6thManager AMgr;

	private Action[] openBack;

	private Func<bool>[] IsHaveDataBack;

	private Func<bool>[] IsNotStartBack;

	private long[] StartTime;

	private Func<bool>[] IsOpenBack;

	private Func<bool>[] IsEndBack;

	private Func<bool>[] IsGameEndBack;

	private long[] GameEndTime;

	private long[] EndTime;

	private Func<bool>[] IsHaveRed;

	private string[] nameKey;

	private string[] notificationKey;

	private long showTimex;

	private string timeKey;

	public void Init()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void Click()
	{
	}

	private void UpdateTime()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void RefreshShopRed()
	{
	}
}
