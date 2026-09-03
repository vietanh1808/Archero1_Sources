using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class NewPlay126RemouldStoneSelectUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText stoneDescTitle;

	[SerializeField]
	private DxxText stoneDesc;

	[SerializeField]
	private DxxText subTitle;

	[SerializeField]
	private DxxText selectBtnName;

	[SerializeField]
	private Image curSelectStoneImg;

	[SerializeField]
	private Image curSelectStoneQuality;

	[SerializeField]
	private GameObject selectStatus;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl selectBtn;

	[SerializeField]
	private Transform stoneParent;

	[SerializeField]
	private NewPlay126RemouldStoneSelectItem selectItem;

	[SerializeField]
	private ScrollRect scrollRect;

	private int curSlotStoneIndex;

	private NewPlay126MonsterRemouldStoneDropItemData originStoneData;

	private NewPlay126MonsterRemouldStoneDropItemData curSelectStoneData;

	private LocalUnityObjctPool pool;

	private NewPlay126Manager NewPlay126Manager => null;

	private NewPlay126MonsterRemouldStoneData NewPlay126MonsterRemouldStoneData => null;

	private bool IsSelectValidStone => false;

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

	private void Refresh()
	{
	}

	private void RefreshData(int curSlotStoneIndex, NewPlay126MonsterRemouldStoneDropItemData curSelectStoneData)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshText()
	{
	}

	private void ClickCloseBtn()
	{
	}

	private void ClickSelectBtn()
	{
	}

	private void Esc()
	{
	}
}
