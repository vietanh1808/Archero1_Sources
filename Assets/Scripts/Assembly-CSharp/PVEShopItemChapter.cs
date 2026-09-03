using System.Collections.Generic;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class PVEShopItemChapter : UITableViewCell
{
	private static Color[] fontColors;

	private static Color[] fontColorDesc;

	public static Color[] colors;

	public DxxText Text_Title;

	public DxxText Text_Desc;

	public ShopOneStageDiscountOneCtrl[] items;

	public DxxText Text_Price;

	public DxxText Text_PriceBefore;

	public Image Image_RedLine;

	public GameObject Icon_Value;

	public DxxText Text_Crit;

	public Button Button_Left;

	public Button Button_Right;

	public ButtonCtrl Button_All;

	public Image Image_BG;

	public DxxImage Image_Top;

	public DxxImage Image_Bottom;

	public DxxImage Image_Bottom_2;

	public Image Image_Light;

	public GuildBoxButton Button_Guild;

	public DxxText Text_Guild;

	private List<PVEShopData> chapterList;

	private PVEShopDataChapter currentChapterData;

	private new int index;

	public VIPFlagItem vipItem;

	public DxxImage[] Adds;

	public DxxText text_StarDiamondBefore;

	public DxxText text_StarDiamond;

	public GameObject go_StarBefore;

	public GameObject go_Star;

	public Image Image_StarRedLine;

	public void init(List<PVEShopData> list)
	{
	}

	public void onButtonLeft()
	{
	}

	public void onButtonRight()
	{
	}

	public void onButtonAll()
	{
	}

	private void initOne(PVEShopData d)
	{
	}

	public void onButtonGuild()
	{
	}

	private void OnButtonStarBuy()
	{
	}

	private bool CheckBuy()
	{
		return false;
	}
}
