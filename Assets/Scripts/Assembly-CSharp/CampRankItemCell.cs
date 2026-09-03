using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampRankItemCell : UITableViewCell
{
	public GameObject BG_Focus;

	public Image Image_Cup;

	public Image Image_Flag;

	public DxxText Text_Rank;

	public DxxText Text_Name;

	public DxxText Text_Peerage;

	public DxxText Text_Score;

	public HeadItem headItem;

	public GameObject BoxObj;

	public Image Image_Box;

	public ButtonCtrl headClick;

	private CampRankItemData data;

	private RectTransform _scrollViewRect;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onClickBox;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(CampRankItemData data, RectTransform scrollRect = null)
	{
	}

	public void onClickBox()
	{
	}

	public void Close()
	{
	}

	private void Update()
	{
	}
}
