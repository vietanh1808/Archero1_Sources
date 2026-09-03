using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class TowerClimb_ItemTipsUICtrl : MediatorCtrlBase
{
	public DxxText Text_RewardTitle;

	public DxxText Text_HarvestAdditionTitle;

	public DxxText Text_HarvestAdditionDesc;

	public Image Img_CurHarvestAddtion;

	public DxxText Text_CurHarvestAddtion;

	public Image Img_NextHarvestAddtion;

	public DxxText Text_NextHarvestAddtion;

	public DxxText Text_SkillTitle;

	public Transform skillDescParent;

	public DxxText Text_TipsDesc;

	public ButtonCtrl Button_Close;

	public TowerClimbItemTips_SkillDesc copyItem;

	public Transform rewardParent;

	public PropOneEquip copyReward;

	public DxxText Text_Title;

	public RectTransform bg;

	public RectTransform skillBg;

	public GameObject arrow;

	public GameObject targetTimeReward;

	public ButtonCtrl Button_Play;

	public DxxText Text_Play;

	private const float SKILLDESC_INTERVAL_Y = 96f;

	private const float REWARDITEM_INTERVAL_X = 98f;

	private List<TowerClimbItemTips_SkillDesc> descList;

	private List<PropOneEquip> rewardList;

	private int curFloor;

	private bool isGuideRunning;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshSkill(Tower_TowerConfig data)
	{
	}

	private void RefreshReward(Tower_TowerConfig data)
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
