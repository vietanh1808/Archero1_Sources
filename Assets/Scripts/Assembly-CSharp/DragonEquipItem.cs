using System;
using DG.Tweening;
using UIKit;
using UnityEngine;

public class DragonEquipItem : UITableViewCell
{
	public DOTweenAnimation child_ani;

	public ButtonCtrl mButton;

	public GameObject mLock;

	public GameObject mChoose_Second;

	public Action<EquipCombineOne> OnButtonClick;

	public EquipOneCtrl mEquip;

	public int Index;

	public DragonCombineData data;

	public bool choosed { get; set; }

	public void Init(int index, DragonCombineData data)
	{
	}

	public void SetLock(bool value)
	{
	}

	public void PlayAni(bool value)
	{
	}

	private void SetButtonEnable(bool value)
	{
	}

	public void setChoosed(bool choose)
	{
	}

	public void setRedPointShowORHide(bool show)
	{
	}

	private void freshState(int state)
	{
	}

	private void onButtonClick()
	{
	}
}
