using UnityEngine;
using UnityEngine.UI;

public class GamePlayActivityOne_NewPlay120 : GamePlayActivityOne_Normal
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

	[SerializeField]
	private GameObject endTimeMask;

	private NewPlay120Manager NewPlay120Manager => null;

	protected override void RefreshData()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void onMaskShow(bool value)
	{
	}

	protected override void OnClickEnter()
	{
	}

	private void EntryRefresh()
	{
	}

	private void RefreshRedNode()
	{
	}

	private void RefreshDifficultyLevel()
	{
	}

	protected override void OnDestroy()
	{
	}
}
