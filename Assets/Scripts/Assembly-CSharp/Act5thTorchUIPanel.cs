using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class Act5thTorchUIPanel : MediatorCtrlBase
{
	public DxxText titleTex;

	public DxxText timeDownTex;

	public DxxText allRewardTex;

	public DxxText btnText;

	public DxxText shopText;

	public DxxText prossText;

	public DxxText matNumText;

	public DxxText leftDonateTex;

	public ButtonCtrl closeBtn;

	public ButtonCtrl tipsBtn;

	public ButtonCtrl okBtn;

	public ButtonCtrl shopBtn;

	public ButtonCtrl bgBtn;

	public Image matIcon;

	public Image fireIcon;

	public Slider prossSlider;

	public Act5thTorchAll act5ThTorchAll;

	public Act5thTorchAllRewardItem nextRewardItem;

	public GameObject paoObj;

	public GameObject lightObj;

	public GameObject rewardObj;

	public GameObject sliderObj;

	public Canvas rewardCancas;

	public Transform effectParent;

	public Transform fireEffectParent;

	public Transform boomEffectParent;

	private Act5thTorchAllRewardItemData nextReward;

	private long showTimex;

	protected override void OnInit()
	{
	}

	public void ClosePanel()
	{
	}

	protected override void OnOpen()
	{
	}

	public void RefreshSortOrder()
	{
	}

	public void Refresh()
	{
	}

	public void ClickDisable()
	{
	}

	public void Donate()
	{
	}

	private void RefreshProgress()
	{
	}

	public void RefreshBtn()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void freshTime()
	{
	}

	private void UpdateTime()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
