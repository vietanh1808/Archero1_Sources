using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingBPItemCell : UITableViewCell
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

	public SailingBPData BPData;

	public ButtonCtrl BtnBuy;

	public DxxText txtBuyPrice;

	private int crtStage;

	private int currentLevel;

	private int costPrice;

	private const string FREE_BP_ITEMBGNAME = "sailing_bp_itemfreebg";

	private const string NORMAL_BP_ITEMBGNAME = "sailing_bp_itemnormalbg";

	private const string PREMIUM_BP_ITEMBG = "sailing_bp_itempreminumbg";

	public void init(SailingBPData data, int level, int stage)
	{
	}

	public void RefreshItemBgByStage()
	{
	}

	public void onButtonGet(int index)
	{
	}

	private void OnButtonBuy()
	{
	}
}
