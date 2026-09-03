using UnityEngine;

public class GamePlayActivityOne_NewPlay122 : GamePlayActivityOne_Normal
{
	public RedNodeCtrl redNode;

	public ButtonCtrl btn_open;

	public ButtonCtrl btn_reward;

	public DxxText txt_reward;

	public DxxText txt_open;

	public DxxText txt_reward_desc;

	public GameObject btn_open_Mask;

	[SerializeField]
	private ButtonCtrl clickBtnTip;

	[SerializeField]
	private ButtonCtrl clickBtnRank;

	protected virtual bool HasAvailableReward => false;

	private bool IsDaily130RankRewardPeriod => false;

	protected override string EndTimeKey => null;

	protected override long LastTime => 0L;

	public override void OnLanguageChange()
	{
	}

	protected override void RefreshData()
	{
	}

	public void OnAfterGetReward()
	{
	}

	private void refresh_btn_open()
	{
	}

	private void RefreshDaily130RankRewardPeriodButtons()
	{
	}

	private void ShowDaily130RankRewardPeriodTip()
	{
	}

	private void onOpen()
	{
	}

	private void onClickReward()
	{
	}

	private bool CheckActivityEnd()
	{
		return false;
	}

	public void EnterGameWrapper()
	{
	}

	protected override void OnClickEnter()
	{
	}

	private void ClickBtnTip()
	{
	}
}
