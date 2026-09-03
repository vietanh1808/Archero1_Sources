using PureMVC.Interfaces;
using UnityEngine;

public class SailingPreInfoUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText[] Text_Info;

	public ButtonCtrl Button_Close;

	public RectTransform Container;

	public PageView pageView;

	public DxxText Text_Number;

	private int currentIndex;

	private int totalPage;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
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

	private void initUI()
	{
	}

	private void onButtonClose()
	{
	}

	public void onPageChanged(int index)
	{
	}

	public void GotoPage(int index)
	{
	}
}
