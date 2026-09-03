using UIKit;
using UnityEngine;

public class MazeTaskItem : UITableViewCell
{
	[SerializeField]
	private ButtonCtrl btn_Go;

	[SerializeField]
	private ButtonCtrl btn_Get;

	[SerializeField]
	private DxxText text_Title;

	[SerializeField]
	private DxxText text_Process;

	[SerializeField]
	private DxxText text_Go;

	[SerializeField]
	private DxxText text_Get;

	public RedNodeCtrl RedPoint;

	public GameObject Mask;

	public GameObject go_Get;

	public ScrollRectBase scroll_Rect;

	public RectTransform rt_Content;

	public PropOneEquip propItem;

	private MazeTaskData itemData;

	private LocalUnityObjctPool pool;

	protected override void Awake()
	{
	}

	public void Init(MazeTaskData data)
	{
	}

	public void OnBtnGetClick()
	{
	}
}
