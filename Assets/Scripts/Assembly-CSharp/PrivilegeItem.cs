using UnityEngine;
using UnityEngine.UI;

public class PrivilegeItem : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private FitContentText descValue;

	[SerializeField]
	private ButtonCtrl click;

	private PrivilegeItemData data;

	public void Refresh(PrivilegeItemData data, bool isDiamondCard = false)
	{
	}

	private void Click()
	{
	}
}
