using System.Collections.Generic;
using TableTool;
using UIKit;
using UnityEngine;

public class MazeRewardItem : UITableViewCell
{
	[SerializeField]
	private DxxText text_Title;

	[SerializeField]
	private PropOneEquip propItem;

	[SerializeField]
	private RectTransform rt_Content;

	[SerializeField]
	private DxxImage icon_Title;

	[SerializeField]
	private DxxImage icon_Bg;

	private LocalUnityObjctPool pool;

	private int crtCircle;

	private ActivityMazeMgr mazeMgr => null;

	protected override void Awake()
	{
	}

	public void Init(List<Drop_DropModel.DropData> props, int color)
	{
	}

	public void InitSpecial(List<Drop_DropModel.DropData> props, int floorID)
	{
	}
}
