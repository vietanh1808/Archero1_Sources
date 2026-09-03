using System.Collections.Generic;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine.UI;

public class PetShopUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public Image Image_IconA;

	public DxxText Text_CountA;

	public PetShopOneInfinity infinity;

	private List<CPetExchangeData> dataList;

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

	private void onButtonClose()
	{
	}

	private void initUI()
	{
	}

	private void freshTime()
	{
	}

	public void showShopList()
	{
	}

	public void UpdateChildCallBack(int index, PetShopItem one)
	{
	}
}
