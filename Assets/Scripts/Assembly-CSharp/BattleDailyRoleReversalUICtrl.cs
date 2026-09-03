using System.Collections.Generic;
using PureMVC.Interfaces;

public class BattleDailyRoleReversalUICtrl : BattleLevelUICtrl
{
	private DailyRoleReversalSkillBtn dailyRoleReversalSkillBtn;

	protected override void OnOpen()
	{
	}

	protected override List<int> GetSelfEquipIds()
	{
		return null;
	}

	protected override void OnClick()
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override bool GetBtnShow()
	{
		return false;
	}

	protected override void OnClose()
	{
	}

	private void SetDailyRoleReversalSkillBtnState(int roomID)
	{
	}

	private void SetDailyRoleReversalSkillBtnVisible(bool canShow)
	{
	}

	private void AlignDailyRoleReversalSkillBtn(bool leftAligned = true)
	{
	}
}
