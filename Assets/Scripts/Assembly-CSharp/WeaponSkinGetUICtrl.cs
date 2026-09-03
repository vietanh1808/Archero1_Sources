using PureMVC.Interfaces;

public class WeaponSkinGetUICtrl : MediatorCtrlBase
{
	public DxxText titleTex;

	public DxxText nameTex;

	public DxxImage iconImg;

	public ButtonCtrl button;

	public DxxText buttonTex;

	public DxxText skinDesTex;

	private int skinId => 0;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void FlyCollectReward()
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
