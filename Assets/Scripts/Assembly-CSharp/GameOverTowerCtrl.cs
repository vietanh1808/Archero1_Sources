using System.Collections.Generic;
using UnityEngine;

public class GameOverTowerCtrl : GameOverLevelCtrl
{
	public class GameOverData
	{
		public int reborn_type;

		public int reborn_count;
	}

	public GameObject bottle;

	public GameObject bottleImg;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateUIBottleStatus(bool isActive)
	{
	}

	private void UpdateUIBottleImgStatus()
	{
	}

	private void OnPlayBtnClick()
	{
	}

	protected override int GetExp()
	{
		return 0;
	}

	protected override bool HaveReward()
	{
		return false;
	}

	protected override int GetDiamond()
	{
		return 0;
	}

	protected override int GetLargeDiamondItem()
	{
		return 0;
	}

	protected override int GetNormalDiamondItem()
	{
		return 0;
	}

	protected override int GetDragonBoxItem()
	{
		return 0;
	}

	protected override List<LocalSave.EquipOne> GetEquips()
	{
		return null;
	}

	protected override void OnLoading()
	{
	}

	public override void PlayRewards()
	{
	}

	protected override void ShowBest()
	{
	}

	protected override void CheckInvalidEquip()
	{
	}

	protected override void excute_reward()
	{
	}

	protected override void CheckWinOrFail()
	{
	}

	protected override void UpdateNewBestUI()
	{
	}

	protected override bool IsShowNewBestUI()
	{
		return false;
	}

	protected override void SendGameOver()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override int get_all_layer()
	{
		return 0;
	}

	protected override void CompleteAllAni()
	{
	}
}
