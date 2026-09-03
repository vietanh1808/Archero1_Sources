using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingTalentPersonalProgressItem : UITableViewCell
{
	public const string FrameType1Unlock = "SailingTalent_Personal_Item1Upgrade";

	public const string FrameType1MaxLevel = "SailingTalent_Personal_Item1Max";

	public const string FrameType2Unlock = "SailingTalent_Personal_Item2Upgrade";

	public const string FrameType2MaxLevel = "SailingTalent_Personal_Item2Max";

	public const string FrameType1Circle = "SailingTalent_Personal_Item1LevelBg";

	public const string FrameType2Circle = "SailingTalent_Personal_Item2LevelBg";

	[SerializeField]
	private DxxText id;

	[SerializeField]
	private CampTalentPersonalProgressLine personalLine;

	[SerializeField]
	private Image icon1;

	[SerializeField]
	private Image icon2;

	[SerializeField]
	private Image frameType1;

	[SerializeField]
	private Image frameType2;

	[SerializeField]
	private GameObject frameType1Mask;

	[SerializeField]
	private GameObject frameType2Mask;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	[SerializeField]
	private Image circleBg;

	[SerializeField]
	private ButtonCtrl click;

	private SailingTalentPersonalProgressItemData data;

	private Color type1TextColor;

	private Color type2TextColor;

	public void Refresh(SailingTalentPersonalProgressItemData data)
	{
	}

	public void RefreshRed()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshIcon()
	{
	}

	private void Click()
	{
	}
}
