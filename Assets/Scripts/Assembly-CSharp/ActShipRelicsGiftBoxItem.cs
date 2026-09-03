using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class ActShipRelicsGiftBoxItem : UITableViewCell
{
	[SerializeField]
	private int Location;

	public GameObject BoxOpen;

	public GameObject BoxClose;

	public ButtonCtrl Button_Box;

	public GameObject Many;

	public Animation BoxAni;

	public ButtonCtrl Button_Info;

	public Image Image_BoxOpen;

	public Image Image_BoxClose;

	public DxxText Text_Name;

	private int type;

	private bool haveGet;

	public new void Awake()
	{
	}

	public void init(int type, bool have, bool playAni)
	{
	}

	public void PlayAnimation()
	{
	}

	public void onButtonGet()
	{
	}

	public void onClickItem(PropOneBase item, object param)
	{
	}

	private void onButtonInfo()
	{
	}
}
