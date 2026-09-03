using System.Collections.Generic;
using Dxx.Net;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class EquipResetCtrl : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnReset;

	[SerializeField]
	private DxxText txtReset;

	[SerializeField]
	private DxxText txtDesc;

	[SerializeField]
	private DxxText txtBtnReset;

	[SerializeField]
	private DxxText txtResetCost;

	[SerializeField]
	private GameObject goMaskRoot;

	[SerializeField]
	private EquipCombineOne equipForAnimation;

	[SerializeField]
	private GameObject itemTemplate;

	[SerializeField]
	private PropOneEquip propEquip;

	[SerializeField]
	private PropOneEquip[] propReturnList;

	[SerializeField]
	private GameObject effectFire;

	[SerializeField]
	private EquipCombineInfinity infinity;

	[SerializeField]
	private ScrollRect scrollRect;

	private List<EquipCombineOne> itemList;

	private LocalSave.EquipOne selected;

	private SequencePool seqPool;

	private List<LocalSave.EquipOne> dataList;

	private Vector2 scrollsize;

	private int height;

	private int LineCount;

	private LocalUnityObjctPool mEquipOnePool;

	public void OnInit(LocalUnityObjctPool pool)
	{
	}

	public void OnOpen()
	{
	}

	public void InitUI()
	{
	}

	private void UpdateChildCallBack(int index, EquipCombineOne one)
	{
	}

	private void OnClickOne(EquipCombineOne one)
	{
	}

	private void SetGuideInfo(int index)
	{
	}

	private void OnBtnReset()
	{
	}

	private void OnResetResponse(NetResponse response)
	{
	}

	private void android_escape()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshPreview()
	{
	}

	private void RefreshInventory()
	{
	}

	private int Comparison(LocalSave.EquipOne a, LocalSave.EquipOne b)
	{
		return 0;
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnGetEvent(string eventName)
	{
	}

	public void OnLanguageChange()
	{
	}
}
