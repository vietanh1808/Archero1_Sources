using UIKit;
using UnityEngine.UI;

public class SailingArenaRankItem : UITableViewCell
{
	public Image Image_Cup;

	public DxxText Text_Rank;

	public Image Image_Flower;

	public HeadItem headItem;

	public ButtonCtrl Button_Head;

	public MedalItem medalItem;

	public Image Icon_Military;

	public DxxText Text_Name;

	public DxxText Text_Score;

	public bool isBottomMe;

	private SailingArenaItemData itemData;

	public new void Awake()
	{
	}

	public void init(SailingArenaItemData data)
	{
	}

	private void onButtonHead()
	{
	}

	private void onButtonChallenge()
	{
	}
}
