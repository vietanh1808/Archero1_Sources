using UIKit;
using UnityEngine;

public class PVEExcInItem : UITableViewCell
{
	public PropOneEquip propOne;

	public DxxText Text_Have;

	public ButtonCtrl Button_Exchange;

	public DxxText Text_Cost;

	private LocalSave.ExcInData data;

	private int needCoin;

	[SerializeField]
	private DxxText Text_Title;

	public void init(LocalSave.ExcInData data)
	{
	}

	private void onButtonClick()
	{
	}

	private bool checkCanExchange()
	{
		return false;
	}
}
