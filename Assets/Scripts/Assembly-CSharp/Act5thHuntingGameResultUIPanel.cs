using DG.Tweening;
using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class Act5thHuntingGameResultUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText animalTitle;

	[SerializeField]
	private DxxText rewardTitle;

	[SerializeField]
	private DxxText quitBtnName;

	[SerializeField]
	private DxxText continueBtnName;

	[SerializeField]
	private DxxText killAnimalEmptyTip;

	[SerializeField]
	private DxxText rewardEmptyTip;

	[SerializeField]
	private ButtonCtrl quitBtn;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private Transform animalItemParent;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private Act5thHuntingGameResultAnimalItem animalItem;

	[SerializeField]
	private ScrollRect animalScrollRect;

	[SerializeField]
	private ScrollRect rewardScrollRect;

	[SerializeField]
	private DxxText killAnimal;

	[SerializeField]
	private DxxText getScore;

	[SerializeField]
	private GridLayoutGroup animalGridLayoutGroup;

	[SerializeField]
	private GridLayoutGroup rewardGridLayoutGroup;

	private SequencePool sequencePool;

	private LocalUnityObjctPool pool;

	private Tweener animalScrollAni;

	private Tweener rewardScrollAni;

	private Act5thHuntingGameResultData data;

	private Act5thHuntingResulPanelType ResultType => Act5thHuntingResulPanelType.None;

	private int PerRowAnimalCount => 0;

	private int PerRowRewardCount => 0;

	protected override void OnInit()
	{
	}

	private void InitEntityPool()
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

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshAnimal()
	{
	}

	private void RefreshReward()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickQuitBtn()
	{
	}

	private void ClickCloseBtn()
	{
	}

	private void Esc()
	{
	}
}
