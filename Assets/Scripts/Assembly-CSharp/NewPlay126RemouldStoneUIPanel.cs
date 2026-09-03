using PureMVC.Interfaces;
using UnityEngine;

public class NewPlay126RemouldStoneUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private ButtonCtrl returnBtn;

	[SerializeField]
	private Transform stoneItemParent;

	[SerializeField]
	private NewPlay126RemouldStoneItem stoneItem;

	[SerializeField]
	private Transform monsterModelParent;

	private LocalUnityObjctPool pool;

	private NewPlay126Manager NewPlay126Manager => null;

	protected override void OnInit()
	{
	}

	private void InitPool()
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

	private void RefreshModel()
	{
	}

	private void RefreshItem()
	{
	}

	private void ClickReturnBtn()
	{
	}

	private void Esc()
	{
	}
}
