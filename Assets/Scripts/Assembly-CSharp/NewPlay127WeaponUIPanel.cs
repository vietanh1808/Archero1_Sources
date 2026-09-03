using PureMVC.Interfaces;
using UnityEngine;

public class NewPlay127WeaponUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ChangeWeaponPanel changeWeaponPanel;

	[SerializeField]
	private NewPlay127DecomposingWeaponUIPanel decomposingWeaponUIPanel;

	[SerializeField]
	private ToggleGroup toggleGroup;

	[SerializeField]
	private ButtonCtrl clickMask;

	[SerializeField]
	private DxxText changeSelectBtnName;

	[SerializeField]
	private DxxText changeUnSelectBtnName;

	[SerializeField]
	private DxxText decomposeSelectBtnName;

	[SerializeField]
	private DxxText decomposeUnSelectBtnName;

	private int curClickTab;

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

	private void Esc()
	{
	}

	public void ClickTab(int index)
	{
	}

	private void Refresh()
	{
	}
}
