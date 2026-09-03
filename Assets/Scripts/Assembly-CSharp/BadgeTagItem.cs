using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class BadgeTagItem : UITableViewCell
{
	[SerializeField]
	private int UILocation;

	[SerializeField]
	private DxxText Text_TagName;

	[SerializeField]
	private Image Image_KV;

	[SerializeField]
	private DxxText Text_Progress;

	[SerializeField]
	private Image Image_Progress;

	[SerializeField]
	private DxxText Text_Slier;

	[SerializeField]
	private GameObject ArrowObj;

	[SerializeField]
	private GameObject OpenObj;

	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private DxxText LockText;

	[SerializeField]
	private DxxText Text_Tips;

	[SerializeField]
	private ButtonCtrl Button_Tag;

	[SerializeField]
	private GameObject RedDot;

	public ScrollRect scrollRect;

	public Image ScrollImage;

	public RectTransform Content;

	public GameObject cpItem;

	public DxxText Text_Reward;

	private BadgeTagItemData _tagItemData;

	private int TagOpen;

	private int TagCurrent;

	public void Init(BadgeTagItemData itemData)
	{
	}

	public void OnClickEnter()
	{
	}
}
