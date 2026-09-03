using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class BadgeBagItem : UITableViewCell
{
	[SerializeField]
	private Image Image_Card;

	[SerializeField]
	private Image Image_Quality;

	[SerializeField]
	private DxxText Text_Progress;

	[SerializeField]
	private Image Image_Progress;

	[SerializeField]
	private ButtonCtrl Button_Open;

	[SerializeField]
	private GameObject go_Completed;

	[SerializeField]
	private GameObject go_Box;

	[SerializeField]
	private GameObject go_UP;

	[SerializeField]
	private GameObject RedDot;

	private BadgeBagItemData _bagItemData;

	public void Init(BadgeBagItemData itemData)
	{
	}

	private void OnClickOpen()
	{
	}

	public void onButtonUp()
	{
	}
}
