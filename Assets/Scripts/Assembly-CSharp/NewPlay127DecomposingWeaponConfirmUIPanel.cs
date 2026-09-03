using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class NewPlay127DecomposingWeaponConfirmUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText desc;

	[SerializeField]
	private DxxText btnName;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl decomposingBtn;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private NewPlay127DecomposingWeaponSelectItem weaponSelectItem;

	private LocalUnityObjctPool pool;

	private List<DIYEquipVO> selectWeaponData;

	private Action decomposingAct;

	private void InitPool()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void Esc()
	{
	}
}
