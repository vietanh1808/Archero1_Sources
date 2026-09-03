using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBackHarvestUICtrl : MediatorCtrlBase
{
	public UILineCtrl mTitleCtrl;

	public Text mUILineCtrl;

	public ButtonCtrl Button_Sure;

	public Text button_Text;

	public GameObject Content;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	private LocalUnityObjctPool mPool;

	private CRespOldUsersBack uBack;

	private GameObject _harvestitem;

	private GameObject harvestitem => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void InitUI()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
