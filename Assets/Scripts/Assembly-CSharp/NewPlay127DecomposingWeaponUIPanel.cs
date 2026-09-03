using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class NewPlay127DecomposingWeaponUIPanel : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private NewPlay127DecomposingWeaponSelectItem weaponSelectItem;

	[SerializeField]
	private NewPlay127DecomposingWeaponItem weaponItem;

	[SerializeField]
	private NewPlay127DecomposingWeaponResultItem resultItem;

	[SerializeField]
	private DxxText decomposingResultTitle;

	[SerializeField]
	private DxxText selectTitle;

	[SerializeField]
	private DxxText decomposingBtnName;

	[SerializeField]
	private ButtonCtrl decomposingBtn;

	[SerializeField]
	private Transform weaponParent;

	[SerializeField]
	private RectTransform selectWeaponParent;

	[SerializeField]
	private Transform resultParent;

	private const int ChangePivotItemCount = 5;

	private LocalUnityObjctPool pool;

	private List<DIYEquipVO> selectWeaponData;

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

	public void SetActiveStatus(bool isActive)
	{
	}

	public void Refresh()
	{
	}

	private void RefreshForce()
	{
	}

	private void RefreshAll()
	{
	}

	private void RefreshWeaponItem()
	{
	}

	private void RefreshSelectStatus()
	{
	}

	private void RefreshSelectLayout()
	{
	}

	private void RefreshSelectItem()
	{
	}

	private void RefreshDecomposingResult()
	{
	}

	private void RefreshDecomposingBtnStatus()
	{
	}

	private void OnDecomposingBtnClick()
	{
	}

	private void DecomposingAllSelectItem()
	{
	}
}
