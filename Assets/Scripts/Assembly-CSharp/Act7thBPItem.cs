using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Act7thBPItem : UITableViewCell
{
	public PropOneEquip[] propItem;

	public GameObject[] Locker;

	public GameObject[] Choosed;

	public GameObject[] GetTween;

	public DxxText[] Tween_Text;

	public Button[] Button_GetItem;

	public GameObject[] Mask;

	public GameObject Line_Yellow;

	public GameObject Line_Dark;

	public GameObject LvBG_Yellow;

	public GameObject LvBG_Dark;

	public DxxText Text_Level;

	public GameObject Shine;

	public GameObject ShineFree;

	public Act7thBPItemData itemData;

	public ButtonCtrl BtnBuy;

	public DxxText txtBuyPrice;

	private int currentLevel;

	private int needDiamond;

	public void init(Act7thBPItemData data, int level)
	{
	}

	public void onButtonGet(int index)
	{
	}

	private void onButtonBuy()
	{
	}
}
