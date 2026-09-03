using UIKit;
using UnityEngine.UI;

public class SailingArenaVSItem : UITableViewCell
{
	public HeadItem headItem;

	public ButtonCtrl Button_Head;

	public Image Icon_Military;

	public DxxText Text_Name;

	public DxxText Text_Power;

	public DxxText Text_Score;

	public DxxText Text_Win;

	public DxxText Text_Add;

	public DxxText Text_Lose;

	public DxxText Text_Reduce;

	public ButtonCtrl Button_Challenge;

	public DxxText Text_Challenge;

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
