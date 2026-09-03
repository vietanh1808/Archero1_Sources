using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class BraveCampTaskItemCell : UITableViewCell
{
	public ScrollRect scrollRect;

	public Image ScrollImage;

	public RectTransform Content;

	public GameObject cpItem;

	public DxxText Text_Title;

	public DxxText Text_Progress;

	public ButtonCtrl Button_Go;

	public DxxText Text_Go;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public GameObject Mask;

	public GameObject RedPoint;

	private BraveCampTaskItemData itemData;

	public new void Awake()
	{
	}

	public void init(BraveCampTaskItemData data)
	{
	}

	private void onButtonGet()
	{
	}
}
