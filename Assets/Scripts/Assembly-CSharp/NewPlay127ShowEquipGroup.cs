using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class NewPlay127ShowEquipGroup : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private GameObject content;

	[SerializeField]
	private EquipOneCtrl equipWeapon;

	[SerializeField]
	private Transform equipItemParent;

	[SerializeField]
	private NewPlay127ShowEquipItem equipItem;

	[SerializeField]
	private ScrollRect scrollRect;

	private LocalUnityObjctPool pool;

	private DIYEquipVO CurUseWeapon => null;

	private bool IsUseWeapon => false;

	private bool HaveEquipItem => false;

	private bool IsUsingShowWeapon => false;

	private bool HaveShowEquipItem => false;

	private void InitPool()
	{
	}

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void Refresh()
	{
	}

	private void RefreshWeapon()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshStatus()
	{
	}

	private NewPlay127ShowEquipItem CreateOneItem()
	{
		return null;
	}
}
