using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class ChangeSantaCompPanel : MediatorCtrlBase
{
	public DIYEquipVO curDiyCompVO;

	public ChangeSantaCompCtrl SantaCompPrefab;

	public Transform SantaCompParent;

	public ChangeSantaCompCtrl CurSantaCompCtrl;

	public ButtonCtrl btnOK;

	public ButtonCtrl btnClose;

	public DxxText txtProperties;

	public DxxText txtTitle;

	public DxxText txtAttr;

	public DxxText txtList;

	public DxxText txtOK;

	private LocalUnityObjctPool mPool;

	private int oldDiyId;

	private List<DIYEquipVO> curList;

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

	private List<DIYEquipVO> GetOrderList()
	{
		return null;
	}

	private void refreshTxtProperties()
	{
	}

	private void refreshCompItems(List<DIYEquipVO> list)
	{
	}

	private void clearCompItems()
	{
	}

	private void initPool()
	{
	}
}
