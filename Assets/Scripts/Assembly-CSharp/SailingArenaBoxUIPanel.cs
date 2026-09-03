using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SailingArenaBoxUIPanel : MediatorCtrlBase
{
	public GameObject BoxClose;

	public GameObject BoxOpen;

	public GameObject Reward;

	public DxxText Text_Desc1;

	public DxxText Text_Desc2;

	public ScrollRect scrollRect1;

	public Image ScrollImage1;

	public RectTransform Content1;

	public ScrollRect scrollRect2;

	public Image ScrollImage2;

	public RectTransform Content2;

	public GameObject cpItem;

	private int minShow;

	private Vector3 v30;

	private Vector3 v31;

	private Vector3 v32;

	private float dtime;

	public void PlayBoxAni()
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

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void initUI()
	{
	}

	private void addRewards(bool yesterday, List<string> rewards)
	{
	}

	public void onButtonClose()
	{
	}

	private void Esc()
	{
	}
}
