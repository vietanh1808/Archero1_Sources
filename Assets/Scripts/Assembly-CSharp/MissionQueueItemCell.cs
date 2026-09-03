using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class MissionQueueItemCell : UITableViewCell
{
	public Image Image_IconBG;

	public Image Image_Icon;

	public DxxText Text_Topline;

	public GameObject ScrollIcon35;

	public GameObject ScrollIcon36;

	public DxxText ScrollNumNeed;

	public DxxText Text_RightTime;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public GameObject prop;

	public ScrollRect scroll;

	public RectTransform Container;

	public MissionEmployItemData data;

	private int iconId;

	protected new void Awake()
	{
	}

	public void init(MissionEmployItemData data)
	{
	}

	public void onButtonGet()
	{
	}
}
