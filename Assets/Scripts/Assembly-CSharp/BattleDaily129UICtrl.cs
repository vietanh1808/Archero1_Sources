using Daily129;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BattleDaily129UICtrl : BattleLevelUICtrl
{
	private const string TAG = "BattleDaily129UICtrl";

	[SerializeField]
	private ButtonCtrl _btnCall;

	[SerializeField]
	private DxxText _textBtnCall;

	[SerializeField]
	private DxxText _textCallPrice;

	[SerializeField]
	private ButtonCtrl _btnStrengthen;

	[SerializeField]
	private DxxText _textBtnStrengthen;

	[SerializeField]
	private DxxText _textStrengthenPrice;

	[SerializeField]
	private BattleBossHPCtrl _battleBossHpCtrl;

	[SerializeField]
	private Image _imgSuperSkillIcon;

	[SerializeField]
	private Image _imgSuperSkillMask;

	[SerializeField]
	private DxxText _textHp;

	[SerializeField]
	private BattleGoldCtrl _prop34115Ctrl;

	private Daily129Manager _daily129Manager;

	protected override bool CanShowSpeedBtn => false;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void CheckGuide(int index = 0)
	{
	}

	private void UpdateSuperSkillIcon()
	{
	}

	private void UpdatePrices()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void SetPetSkillBtnGroupState()
	{
	}

	protected override void LevelUp()
	{
	}
}
