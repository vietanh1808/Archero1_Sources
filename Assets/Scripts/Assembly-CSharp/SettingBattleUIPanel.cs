using PureMVC.Interfaces;
using UnityEngine;

public class SettingBattleUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private Transform settingItemParent;

	[SerializeField]
	private SettingBattleItem settingItem;

	private LocalUnityObjctPool pool;

	private int showType;

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

	private void RefreshText()
	{
	}

	private void RefreshItem()
	{
	}

	private void ClickCloseBtn()
	{
	}

	private void Esc()
	{
	}
}
