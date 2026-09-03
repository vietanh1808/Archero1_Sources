using UnityEngine;
using UnityEngine.UI;

public class GamePlayActivityOne_NewPlay128 : GamePlayActivityOne_Normal
{
	[SerializeField]
	public DxxText seasonRewardText;

	[SerializeField]
	private Image difficultyBg;

	[SerializeField]
	private DxxText difficultyLevel;

	[SerializeField]
	private DxxText difficultyName;

	[SerializeField]
	private ButtonCtrl difficultyBtn;

	[SerializeField]
	private ButtonCtrl seasonBtn;

	[SerializeField]
	private GameObject redNode;

	[SerializeField]
	private GameObject difficultyLevelMask;

	protected override void RefreshData()
	{
	}

	private void UpdateLevel(int id)
	{
	}

	protected override void OnEnterGame()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
