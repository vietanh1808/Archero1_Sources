using UnityEngine;
using UnityEngine.UI;

public class BadgePreviewCardItem : MonoBehaviour
{
	[SerializeField]
	private DxxText Text_Have;

	[SerializeField]
	private Image Image_Card;

	[SerializeField]
	private Image Image_Quality;

	[SerializeField]
	private Image Image_BG;

	[SerializeField]
	private GameObject HaveNoObj;

	[SerializeField]
	private ButtonCtrl Button_Item;

	private BadgeCardItemData itemData;

	public void Init(BadgeCardItemData data)
	{
	}

	private void onButtonItem()
	{
	}
}
