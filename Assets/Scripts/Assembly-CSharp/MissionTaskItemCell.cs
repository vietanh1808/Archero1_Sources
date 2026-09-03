using System.Collections.Generic;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class MissionTaskItemCell : UITableViewCell
{
	public DxxText Text_TopLeft;

	public DxxText Text_TopCount;

	public GameObject Content;

	public DxxText Text_Tips;

	public GameObject Icon1;

	public GameObject Icon2;

	public DxxText Text_Count;

	public Slider slider;

	public DxxText slider_Info;

	public DxxText slider_Title;

	public ButtonCtrl Button_Get;

	public Image Button_GetBG;

	public DxxText Text_Get;

	public ButtonCtrl Button_Fresh;

	public DxxText Text_Price;

	public GameObject Icon_Diamond;

	public MissionTaskItemData data;

	private int FreshNeedDiamond;

	private int freshNeedT;

	protected new void Awake()
	{
	}

	public void init(MissionTaskItemData data)
	{
	}

	private void UpdateFreshTime()
	{
	}

	public void onButtonGet()
	{
	}

	public void onButtonFresh()
	{
	}

	private List<string> GetTaskContentParam(MissionTaskItemData mtid)
	{
		return null;
	}

	private string GetStringByAgrsType(int type, int value)
	{
		return null;
	}

	private void onButtonGo()
	{
	}
}
