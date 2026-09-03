using UnityEngine;
using UnityEngine.UI;

public class GamePlayActivityOne_Maze : GamePlayActivityOne_Normal
{
	public GoldTextCtrl titleText;

	public GoldTextCtrl titleTextAlone;

	public ButtonCtrl buttonSeason;

	public DxxText seasonRewardText;

	[SerializeField]
	private Image _imgRedNode;

	protected override void RefreshData()
	{
	}

	private void OnClickSeasonBtn()
	{
	}

	protected override void OnClickEnter()
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
