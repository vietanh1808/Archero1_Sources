using System.Collections.Generic;
using UIKit;
using UnityEngine;

public class CashGiftTaskItem : UITableViewCell
{
	public DxxText Text_Desc;

	public DxxText Text_Rev;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public ButtonCtrl Button_Go;

	public DxxText Text_Go;

	public AdsController ads;

	public ButtonCtrl Button_Ad;

	public GameObject Red;

	public LocalSave.CashTaskItemData data;

	protected new void Awake()
	{
	}

	public void init(LocalSave.CashTaskItemData data)
	{
	}

	public void onButtonGet()
	{
	}

	private List<string> GetTaskContentParam(LocalSave.CashTaskItemData ctid)
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

	private void onButtonAd()
	{
	}
}
