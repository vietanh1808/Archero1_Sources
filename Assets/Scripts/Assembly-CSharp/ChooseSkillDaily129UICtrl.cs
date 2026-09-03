using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSkillDaily129UICtrl : ChooseSkillABTestUICtrl
{
	[SerializeField]
	private Image[] _heads;

	private List<int> _ids;

	protected override bool CanShowLockSkillTips => false;

	protected override void OnOpen()
	{
	}

	protected override void SetRefreshBtnShow(bool show)
	{
	}

	protected override List<int> GetSkillList()
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
