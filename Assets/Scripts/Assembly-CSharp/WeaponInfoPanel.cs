using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class WeaponInfoPanel : MediatorCtrlBase
{
	private DIYEquipVO curDiyWeaponVO;

	public SantaCompCtrl SantaCompPrefab;

	public Transform SantaCompParent;

	public EquipOneCtrl EquipOneUI;

	public ButtonCtrl btnChoose;

	public ButtonCtrl btnClose;

	public ButtonCtrl btnReturn;

	public DxxText txtGrids;

	public DxxText txtChange;

	public DxxText txtCompTitle;

	public RedNodeCtrl redNodeCtrl;

	private LocalUnityObjctPool mPool;

	private List<DIYEquipVO> santaCompVOs => null;

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

	private void initPool()
	{
	}

	private void closeInternal()
	{
	}

	private void refreshCurWeapon(DIYEquipVO vo)
	{
	}

	private void refreshTxtGrids()
	{
	}

	private void refreshSantaCompList()
	{
	}

	private void clearSantaComps()
	{
	}

	private void refreshRedNode()
	{
	}
}
