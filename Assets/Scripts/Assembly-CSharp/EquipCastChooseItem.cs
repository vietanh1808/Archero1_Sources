using UIKit;
using UnityEngine;

public class EquipCastChooseItem : UITableViewCell
{
	public EquipOneCtrl equipOne;

	public GameObject checkObj;

	public DxxText Text_Have;

	public NewFlagItem newItem;

	private EquipCastChoosePanel choosePanel;

	private bool choosed;

	public void init(EquipCastChoosePanel panel, LocalSave.EquipOne one, bool used, bool have)
	{
	}

	private void onButtonClick(object o)
	{
	}
}
