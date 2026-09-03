using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class BraveCampRewardItemCell : UITableViewCell
{
	public ScrollRect scrollRect;

	public Image ScrollImage;

	public RectTransform Content;

	public GameObject cpItem;

	public DxxText Text_Title;

	public DxxText Text_Progress;

	public PropOneEquip specialRewardItem;

	public GameObject Mask;

	private BraveCampMgr.BraveCampRewardConfig itemData;

	private bool isSelf => false;

	public new void Awake()
	{
	}

	public void init(BraveCampMgr.BraveCampRewardConfig data)
	{
	}
}
