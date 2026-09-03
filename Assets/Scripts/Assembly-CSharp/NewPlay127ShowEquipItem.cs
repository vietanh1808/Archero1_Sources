using UnityEngine;
using UnityEngine.UI;

public class NewPlay127ShowEquipItem : MonoBehaviour
{
	[SerializeField]
	private GameObject equipItem;

	[SerializeField]
	private Image quality;

	[SerializeField]
	private Image icon;

	private DIYEquipVO itemData;

	private bool HaveEquip => false;

	public void Refresh(DIYEquipVO itemData)
	{
	}

	private void RefreshStatus()
	{
	}
}
