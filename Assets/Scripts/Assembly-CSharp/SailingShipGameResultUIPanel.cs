using PureMVC.Interfaces;
using UnityEngine;

public class SailingShipGameResultUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText resultTitle;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private SailingShipGameResultItem selfResultItem;

	[SerializeField]
	private SailingShipGameResultItem enemyResultItem;

	[SerializeField]
	private SailingShipGameResultAni resultAni;

	[SerializeField]
	private ButtonCtrl jumpAniBtn;

	[SerializeField]
	private DxxText jumpAniBtnName;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private DxxText closeBtnName;

	[SerializeField]
	private DxxText scoreGetText;

	[SerializeField]
	private DxxText damageText;

	public const float SailingShipGameResultPropItemScale = 0.9f;

	private LocalUnityObjctPool pool;

	private SailingShipManager SailingShipManager => null;

	private SailingShipGameData SailingShipGameData => null;

	private SailingShipWarningData SailingShipWarningData => null;

	private SailingShipBattleResultData SailingShipBattleResultData => null;

	private void InitPool()
	{
	}

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

	private void RefreshPlayerInfo()
	{
	}

	private void RefreshItem()
	{
	}

	private void ClickCloseBtn()
	{
	}

	private void ClickJumpAniBtn()
	{
	}

	private string GetScoreText()
	{
		return null;
	}
}
