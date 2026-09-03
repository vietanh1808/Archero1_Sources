using PureMVC.Interfaces;
using UnityEngine.UI;

public class PetGetUIPanel : MediatorCtrlBase
{
	public Image Image_Banner;

	public DxxText titleTex;

	public DxxText nameTex;

	public ButtonCtrl button;

	public DxxText buttonTex;

	public DxxText skinDesTex;

	public RawImage petImg;

	private HeroShow heroShow;

	private int petId;

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
}
