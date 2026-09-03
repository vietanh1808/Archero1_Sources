using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Act7thSignItem : UITableViewCell
{
	public GameObject BG1;

	public GameObject BG2;

	public DxxText Text_Day;

	public GameObject Right;

	public GameObject Check;

	public DxxText Text_Time;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public GameObject Mask;

	public ScrollRect scrollRect;

	public Image ScrollImage;

	public RectTransform Content;

	public GameObject cpItem;

	private int minShow;

	private Act7thSignItemData itemData;

	public new void Awake()
	{
	}

	public void init(Act7thSignItemData data)
	{
	}

	private void onButtonGet()
	{
	}

	private void freshTime()
	{
	}
}
