using System;
using System.Collections.Generic;
using UIKit;
using UnityEngine;

public class BeliefProgressItem : UITableViewCell
{
	[SerializeField]
	private BeliefProgressLine personalLine;

	[SerializeField]
	private DxxImage frameIcon1;

	[SerializeField]
	private DxxImage frameIcon2;

	[SerializeField]
	private DxxImage skillIcon;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private ButtonCtrl btn_Reward;

	[SerializeField]
	private DxxImage talentRewardIcon;

	[SerializeField]
	private Animator ani_Reward;

	[SerializeField]
	private GameObject go_Lock;

	[SerializeField]
	private ParticleSystem effect;

	[SerializeField]
	private BeliefEffectEnd effectEnd;

	private BeliefSkillItemData data;

	public Action clickCallBack;

	public Action<RectTransform> rewardClickCallback;

	private Dictionary<int, Vector2> SkillIconSizeMap;

	protected override void Awake()
	{
	}

	public void Refresh(BeliefSkillItemData data, float height, float width)
	{
	}

	public void RefreshRed()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshIcon()
	{
	}

	private void OnBtnRewardClick()
	{
	}

	public void PlayUnlockEffect(int talentID)
	{
	}
}
