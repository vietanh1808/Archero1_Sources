using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine.UI;

public class BattleTowerDefenceUICtrl : BattleLevelUICtrl
{
	public ButtonCtrl mNpcSkillBtn;

	public Image mNpcIcon;

	public DxxText mTextLvUp;

	public Image mImgLvUp;

	private SequencePool mSeqPool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private bool CanLearnNewSkill(int id)
	{
		return false;
	}

	private void UpdateUI()
	{
	}

	private void OnLevelUp(int lv)
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
