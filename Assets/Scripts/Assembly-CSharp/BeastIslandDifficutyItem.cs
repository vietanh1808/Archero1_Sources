using System;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class BeastIslandDifficutyItem : UITableViewCell
{
	public Image difficultImg;

	public DxxText difficultText;

	public DxxText rewardNum;

	public DxxText BtnText;

	public ButtonCtrl selectBtn;

	public GameObject selectObj;

	public GameObject lockObj;

	public DxxText lockDesc;

	public GameObject BpObj;

	public DxxText BPAddTex;

	public Action<BeastIslandDifficultyItemData> selectDo;

	private BeastIslandDifficultyItemData mData;

	private new void Awake()
	{
	}

	public void Init(BeastIslandDifficultyItemData data)
	{
	}

	public void RefreshLock()
	{
	}

	public void RefreshSelect()
	{
	}

	private void ClickSelect()
	{
	}
}
