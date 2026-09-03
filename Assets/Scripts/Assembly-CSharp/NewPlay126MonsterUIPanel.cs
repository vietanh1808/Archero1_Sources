using PureMVC.Interfaces;
using UnityEngine;

public class NewPlay126MonsterUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText subTitle;

	[SerializeField]
	private DxxText monsterName;

	[SerializeField]
	private DxxFitContentText monsterDesc;

	[SerializeField]
	private DxxText selectBtnName;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl selectBtn;

	[SerializeField]
	private Transform monsterModelParent;

	private NewPlay126MonsterEntityGroupItemData monsterData;

	private NewPlay126Manager NewPlay126Manager => null;

	private int CurMonsterID => 0;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	private void Refresh()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshModel()
	{
	}

	private void ClickCloseBtn()
	{
	}

	private void ClickSelectBtn()
	{
	}

	private void Esc()
	{
	}
}
