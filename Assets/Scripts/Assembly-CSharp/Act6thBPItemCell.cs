using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Act6thBPItemCell : UITableViewCell
{
	public PropOneEquip[] propItem;

	public GameObject[] Locker;

	public GameObject[] Choosed;

	public GameObject[] GetTween;

	public DxxText[] Tween_Text;

	public Button[] Button_GetItem;

	public Image[] propItemImage;

	public GameObject Line_Yellow;

	public GameObject Line_Dark;

	public GameObject LvBG_Yellow;

	public GameObject LvBG_Dark;

	public DxxText Text_Level;

	public GameObject Mask;

	public GameObject Shine;

	public GameObject ShineFree;

	public ButtonCtrl BtnBuy;

	public DxxText txtBuyPrice;

	private int crtIndex;

	private int bpLevel;

	private int costPrice;

	private const string FREE_BP_ITEMBGNAME = "sailing_bp_itemfreebg";

	private const string NORMAL_BP_ITEMBGNAME = "sailing_bp_itemnormalbg";

	private const string PREMIUM_BP_ITEMBG = "sailing_bp_itempreminumbg";

	private Act6thManager AMgr => null;

	private Act6thBpRewardData FreeData => null;

	private Act6thBpRewardData NormalData => null;

	public void init(int level, int index)
	{
	}

	public void onButtonGet(int index)
	{
	}

	private void OnButtonBuy()
	{
	}
}
