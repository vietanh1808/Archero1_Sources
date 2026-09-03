using System.Collections.Generic;
using UnityEngine;

public class EndlessRewardPreviewUICtrl : MediatorCtrlBase
{
	public DxxText titleText;

	public DxxText seasonText;

	public DxxText timeText;

	public DxxText descText;

	public DxxText currentText;

	public DxxText okText;

	public DxxText ok2Text;

	public GameObject container;

	public GameObject currentRewardRoot;

	public GameObject tempItem;

	public GameObject tempLineOne;

	public GameObject tempLineTwo;

	public GameObject bg1;

	public GameObject bg2;

	public GameObject panel;

	public GameObject okButton1;

	public GameObject okButton2;

	public Vector3 panelPosition;

	public DxxText rewardTimeText;

	private Dictionary<int, GameObject> rewardObjDict;

	public void OnButtonOK()
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
}
