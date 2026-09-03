using PureMVC.Interfaces;
using UnityEngine;

public class Act5thHuntingTalentPopUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private RectTransform pop;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText desc;

	[SerializeField]
	private ButtonCtrl maskBtn;

	private Act5thHuntingTalentPopData data;

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

	private void RefreshText()
	{
	}

	private void RefreshPos()
	{
	}

	private void Esc()
	{
	}

	private void ClickMaskBtn()
	{
	}
}
