using UnityEngine;
using UnityEngine.UI;

public class RelicSetItemCtrl : MonoBehaviour
{
	public Image image_check;

	public EquipOneCtrl relicOneCtrl;

	private LocalSave.EquipOne mRelicOne;

	public void RefreshUI(LocalSave.EquipOne relicOne)
	{
	}

	private bool isExisted()
	{
		return false;
	}
}
