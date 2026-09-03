using UnityEngine;
using UnityEngine.UI;

public class BadgeBoxItem : MonoBehaviour
{
	public GameObject BoxOpen;

	public GameObject BoxClose;

	public DxxText Text_Need;

	public ButtonCtrl Button_Box;

	public GameObject Single;

	public GameObject Many;

	public PropOneEquip propItem;

	public GameObject Complete;

	public Animation BoxAni;

	public Image Image_BoxOpen;

	public Image Image_BoxClose;

	private BadgeBoxItemData itemData;

	public void Awake()
	{
	}

	public void init(BadgeBoxItemData itemData)
	{
	}

	public void onButtonGet()
	{
	}

	public void onClickItem(PropOneBase item, object param)
	{
	}
}
