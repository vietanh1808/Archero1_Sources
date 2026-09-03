using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class ActIslandVSBoxItemCell : UITableViewCell
{
	public ScrollRect scrollRect;

	public Image ScrollImage;

	public RectTransform Content;

	public GameObject cpItem;

	private int minShow;

	public GameObject BG1;

	public GameObject BG2;

	public GameObject LineObj;

	public GameObject TopObj;

	public GameObject TopLine;

	public GameObject BottomObj;

	public GameObject BottomLine;

	public GameObject Box;

	public GameObject Locker;

	public GameObject Checker;

	public DxxText Text_ID;

	public DxxText Text_Heart;

	public new void Awake()
	{
	}

	public void init(DBBoxPreviewItemData data, int index)
	{
	}
}
