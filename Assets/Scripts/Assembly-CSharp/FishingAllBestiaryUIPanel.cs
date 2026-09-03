using PureMVC.Interfaces;
using UnityEngine;

public class FishingAllBestiaryUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ToggleGroup toggleGroup;

	[SerializeField]
	private FishingBestiaryUIPanel fishBestiary;

	[SerializeField]
	private FishingRodBestiaryUIPanel rodBestiary;

	[SerializeField]
	private DxxText selectFishName;

	[SerializeField]
	private DxxText unselectFishName;

	[SerializeField]
	private DxxText selectRodName;

	[SerializeField]
	private DxxText unselectRodName;

	private IUILifeCycle curPanel;

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

	public void ClickTab(int pageIndex)
	{
	}

	private IUILifeCycle SwitchPanel(int selectIndex)
	{
		return null;
	}

	private void Esc()
	{
	}
}
