using System;
using PureMVC.Interfaces;
using UnityEngine;

public class Act5thActBtn : MonoBehaviour
{
	public int actIndex;

	public DxxText nameTex;

	public DxxText timeText;

	public GameObject effectObj;

	public ButtonCtrl clickBtn;

	public RedNodeCtrl redNode;

	private Action[] openBack;

	private Func<bool>[] IsHaveDataBack;

	private Func<bool>[] IsNotStartBack;

	private long[] StartTime;

	private Func<bool>[] IsOpenBack;

	private Func<bool>[] IsEndBack;

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
}
