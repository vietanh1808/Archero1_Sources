using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactAppraisaTaskItemCell : UITableViewCell
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

	private ArtifactAppraisaTaskItemData itemData;

	public new void Awake()
	{
	}

	public void init(ArtifactAppraisaTaskItemData data)
	{
	}

	private void onButtonGet()
	{
	}
}
