using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ChangeWeaponPanel : MonoBehaviour, IUILifeCycle
{
	public DIYEquipVO curDiyWeaponVO;

	public DIYEquipVO curUsingWeaponVO;

	public SantaWeaponCtrl SantaWeaponPrefab;

	public Transform SantaWeaponParent;

	public EquipOneCtrl EquipOneUI;

	public ButtonCtrl btnOK;

	public DxxText txtProperties;

	public DxxText txtGrids;

	public DxxText txtAttr;

	public DxxText txtList;

	public DxxText txtOK;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private DxxText usingTip;

	[SerializeField]
	private GameObject btnClickObj;

	[SerializeField]
	private GameObject usingTipObj;

	private LocalUnityObjctPool mPool;

	private List<DIYEquipVO> weaponList;

	public void OnLanguageChange()
	{
	}

	public void OnInit()
	{
	}

	public virtual void OnOpen()
	{
	}

	public void SetActiveStatus(bool isActive)
	{
	}

	public void Refresh(DIYEquipVO curUseWeaponData)
	{
	}

	private List<DIYEquipVO> createWeaponList()
	{
		return null;
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnClose()
	{
	}

	private void android_escape()
	{
	}

	private void refreshTxtProperties()
	{
	}

	private void refreshTxtGrids()
	{
	}

	private void refreshCurWeapon(DIYEquipVO vo)
	{
	}

	private void refreshWeaponItems()
	{
	}

	private void RefreshClickBtnStatus()
	{
	}

	private void clearWeaponItems()
	{
	}

	private void initPool()
	{
	}
}
