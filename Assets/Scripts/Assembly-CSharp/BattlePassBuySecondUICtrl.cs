using GameProtocol;

public class BattlePassBuySecondUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Cancel;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_BG;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Cancel;

	public ButtonIAP buttonIAP;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private ButtonIAP.ShowData mShowData;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void ClosePanel()
	{
	}

	private void purchaseCallback(CRespInAppPurchase data, bool success)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
