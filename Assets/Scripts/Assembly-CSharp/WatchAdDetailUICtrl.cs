using System.Collections.Generic;
using UnityEngine;

public class WatchAdDetailUICtrl : MediatorCtrlBase
{
	public DxxText titleTex;

	public GameObject watchAdObj;

	public Transform itemParent;

	public ButtonCtrl backBtn;

	public DxxText btnTex;

	private Dictionary<int, GameObject> items;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
