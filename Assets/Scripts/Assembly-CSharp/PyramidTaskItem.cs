using UIKit;
using UnityEngine;

public class PyramidTaskItem : UITableViewCell
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

	[SerializeField]
	private PropOneEquip propItem;

	public RedNodeCtrl RedPoint;

	public GameObject Mask;

	public GameObject go_Get;

	public ScrollRectBase scroll_Rect;

	private PyramidTaskData itemData;

	private LocalUnityObjctPool pool;

	protected override void Awake()
	{
	}

	public void Init(PyramidTaskData data)
	{
	}

	public void OnBtnGetClick()
	{
	}
}
