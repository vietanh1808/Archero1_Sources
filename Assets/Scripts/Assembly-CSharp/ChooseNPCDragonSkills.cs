using System.Collections.Generic;
using PureMVC.Interfaces;

public class ChooseNPCDragonSkills : MediatorCtrlBase
{
	public DxxText txt_title;

	public DxxText txt_desc;

	public DxxText txt_curDragonCoin;

	public DxxImage img_dragonCoin;

	public NPCDragonSkillItem[] skillItems;

	public DragonSkillRefreshCtrl refreshCtrl;

	public ButtonCtrl btn_close;

	private List<int> skillIds;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void refreshUI()
	{
	}

	private bool isSkillItemsAvailable()
	{
		return false;
	}

	private void refreshSkills()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	private void refreshDragonCoin()
	{
	}
}
