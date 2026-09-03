using System.Collections.Generic;
using UnityEngine;

public class SettingBattleItem : MonoBehaviour
{
	[SerializeField]
	private DxxText settingName;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private GameObject selectObj;

	[SerializeField]
	private GameObject selectGroup;

	[SerializeField]
	private GameObject showSelectNameGroup;

	[SerializeField]
	private DxxText showSelectName;

	private SettingBattleType type;

	private bool isInit;

	private List<SettingBattleType> showselectTypes;

	private List<SettingBattleType> showselectNameTypes;

	private PlayerPrefsMgr PlayerPrefsMgr => null;

	private void Init()
	{
	}

	public void Refresh(SettingBattleType type)
	{
	}

	private void RefreshShow()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickBtn()
	{
	}

	private bool GetIsSelect()
	{
		return false;
	}

	private int GetSelectValue()
	{
		return 0;
	}

	private string GetHabitSelectString()
	{
		return null;
	}
}
