using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class RuneTotalItemCtrl : MonoBehaviour
{
	public DxxText desc;

	public GameObject checkMark;

	public DxxText activateButtonText;

	public ButtonCtrl activateButton;

	public DxxText progress;

	public Image bg;

	private RuneTotalRewardItem data;

	private RuneGroup rune;

	private Runes_Reward dataReward;

	private readonly Color bgColorLocked;

	private readonly Color bgColorUnlocked;

	private readonly Color bgColorActivated;

	private readonly Color textColorLocked;

	private readonly Color textColorUnlocked;

	private readonly Color textColorActivated;

	public void SetData(RuneGroup rune, RuneTotalRewardItem data)
	{
	}

	public void UpdateUI()
	{
	}

	public void OnActivateClicked()
	{
	}

	public float GetHeight()
	{
		return 0f;
	}
}
