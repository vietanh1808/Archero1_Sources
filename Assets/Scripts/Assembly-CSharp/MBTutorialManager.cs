using System.Collections.Generic;
using UnityEngine;

public class MBTutorialManager
{
	private static MBTutorialManager _instance;

	private Dictionary<MBTutorialActionEnum, int> tutorialActionDict;

	private GameObject _arrow;

	public static MBTutorialManager Instance => null;

	public int FinishedTutorialStep => 0;

	public GameObject Arrow => null;

	private void setTutorialStep(int tutorialStep)
	{
	}

	public bool HaveTutorial(MBTutorialActionEnum actionEnum)
	{
		return false;
	}

	public bool BeforeTutorial(MBTutorialActionEnum actionEnum)
	{
		return false;
	}

	public bool HaveFinishedTutorial(MBTutorialActionEnum actionEnum)
	{
		return false;
	}

	public void FinishTutorial(MBTutorialActionEnum actionEnum, bool force = false)
	{
	}

	public void HideArrow()
	{
	}

	public void CheckIfUnlockInMain()
	{
	}

	public void CheckIfUnlockInEggActivity()
	{
	}

	public void CheckIfHaveDenfenseFormationInMeadowBattle()
	{
	}

	public void showArrowOnButton(ButtonCtrl buttonCtrl)
	{
	}
}
