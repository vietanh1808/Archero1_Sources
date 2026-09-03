using PureMVC.Interfaces;
using UnityEngine;

public class ChooseInitWeaponPanel : MediatorCtrlBase
{
	private const int AVAILABLE_WEAPON_COUNT = 3;

	public InitWeaponItemCtrl initWeaponItemCtrl;

	public Transform weaponItemParent;

	public DxxText txt_title;

	private LocalUnityObjctPool mPool;

	public override void OnLanguageChange()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	private void refreshWeaponItems()
	{
	}

	private void clearWeaponItems()
	{
	}

	private void initPool()
	{
	}
}
