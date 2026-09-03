using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class MazeExchangeUICtrl : MediatorCtrlBase
{
	public DxxText titleText;

	public DxxText timeText;

	public DxxText stoneText;

	public DxxText descText;

	public Image roleImage;

	public GameObject container;

	public GameObject tempItem;

	private int material;

	private List<MazeItemCtrl> mazeItems;

	private int[] idx;

	private int currentIdx;

	public void OnButtonClose()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	private void initUI()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void freshUI()
	{
	}

	public static void ShowRewardSimple()
	{
	}

	public void OnButtonTest()
	{
	}
}
