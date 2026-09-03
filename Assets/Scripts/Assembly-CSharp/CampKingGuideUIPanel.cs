using PureMVC.Interfaces;
using UnityEngine;

public class CampKingGuideUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_SubTitle;

	public DxxText Text_Time;

	public CampKingGuideBoxItem boxItem;

	public ButtonCtrl Button_Close;

	public DxxText Text_Guide1_Title;

	public DxxText Text_Guide1_Desc;

	public DxxText Text_Guide1_Reward_Title;

	public RectTransform Content_Guide1;

	public GameObject Pic1_0;

	public GameObject Pic1_1;

	public GameObject Pic1_2;

	public DxxText Text_Guide2_Title;

	public DxxText Text_Guide2_Desc;

	public DxxText Text_Guide2_Desc1;

	public DxxText Text_Guide2_Reward_Title;

	public RectTransform Content_Guide2;

	public DxxText Text_Guide2_Desc2;

	public GameObject Pic2_0;

	public GameObject Pic2_1;

	public GameObject Pic2_2;

	public GameObject cpPropItem;

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

	private void freshTime()
	{
	}
}
