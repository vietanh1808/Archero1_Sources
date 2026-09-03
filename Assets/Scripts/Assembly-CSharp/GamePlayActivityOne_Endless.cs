using UnityEngine;

public class GamePlayActivityOne_Endless : GamePlayActivityOne_Normal
{
	public GoldTextCtrl titleText;

	public GoldTextCtrl titleTextAlone;

	public DxxImage Image_MaxLayer;

	public DxxText Text_MaxLayer;

	public GameObject maskMaxLayer;

	public ButtonCtrl buttonSeason;

	public DxxText seasonRewardText;

	protected override void RefreshData()
	{
	}

	private void OnClickSeasonBtn()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void onMaskShow(bool value)
	{
	}

	private void sendRequestAct()
	{
	}
}
