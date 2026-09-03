using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class PVERankItemCell : UITableViewCell
{
	public Image BG;

	public Image BG_Rank;

	public Image Image_Flower;

	public Image Image_Left;

	public Image Image_BoxBG;

	public DxxText Text_Rank;

	public DxxText Text_Rank2;

	public DxxText Text_Name;

	public DxxText Text_Value;

	public HeadItem headItem;

	public GameObject Icon1;

	public GameObject Icon2;

	public GameObject Icon3;

	public DxxText Text_Talent;

	public Color color1;

	public Color color2;

	public Color color3;

	public Image Image_Reward;

	public MedalItem medalItem;

	private PVERankItemData data;

	private int currentTab;

	private RectTransform _scrollViewRect;

	public void init(PVERankItemData data, RectTransform scrollRect)
	{
	}

	public void SetCurrentTab(int currentTab)
	{
	}

	public void onClickBox()
	{
	}

	public void onButtonOpen()
	{
	}

	public void Close()
	{
	}

	private void Update()
	{
	}
}
