using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Act7thBPBoxItem : UITableViewCell
{
	[SerializeField]
	private ButtonCtrl ButtonBox;

	[SerializeField]
	private Image Image_Box;

	[SerializeField]
	private DxxText Text_Desc;

	[SerializeField]
	private DxxText Text_Num;

	[SerializeField]
	private DxxText Text_Get;

	[SerializeField]
	private GameObject GetTween;

	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private GameObject CheckObj;

	[SerializeField]
	private DxxText Text_Title;

	private Act7thBPBoxData boxData;

	private bool canGet;

	public void init()
	{
	}

	public void onButtonBox()
	{
	}
}
