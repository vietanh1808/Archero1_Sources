using PureMVC.Interfaces;
using UnityEngine.UI;

public class VIPBuyScoreUICtrl : MediatorCtrlBase
{
	public Image Image_VIPBG;

	public DxxText Text_Title;

	public DxxText Text_Lv;

	public DxxText Text_TitleLv;

	public Slider slider;

	public DxxText Slider_Count;

	public ButtonCtrl Button_Close;

	public VIPBuyScoreItem[] Items;

	public DxxText Text_Desc;

	public DxxText Text_Diamond;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void android_escape()
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
}
