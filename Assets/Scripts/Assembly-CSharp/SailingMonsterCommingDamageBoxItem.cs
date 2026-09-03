using System;
using System.Collections.Generic;
using TableTool;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingMonsterCommingDamageBoxItem : UITableViewCell
{
	public Slider sliderProgress;

	public PropOneEquip prop;

	public Image imgBox;

	public ButtonCtrl btnBox;

	public DxxText txtValue;

	public GameObject goBoxGot;

	public Animation aniShake;

	private SailingMonsterAchievementData _crtData;

	private Action<List<Drop_DropModel.DropData>, Vector2> boxClickedCallBack;

	private SailingMonsterCommingMgr SmMgr => null;

	public void Init(SailingMonsterAchievementData aData, int preTarget, Action<List<Drop_DropModel.DropData>, Vector2> boxClicked)
	{
	}

	public void OnRewardClick()
	{
	}
}
