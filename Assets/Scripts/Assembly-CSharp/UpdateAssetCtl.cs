using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class UpdateAssetCtl : MediatorCtrlBase
{
	public GameObject window;

	public DxxText titleText;

	public DxxText dtext;

	public DxxText protext;

	public DxxText processtext;

	public DxxText text1;

	public DxxText text2;

	public DxxText btn_text;

	public Image processImg;

	public ButtonCtrl button_close;

	public ButtonCtrl button_pause;

	public ButtonCtrl button_start;

	public ButtonCtrl button_ok;

	public GameObject FinishedImg;

	private string netStateStr;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void UpdateAssetObjTxt()
	{
	}

	private void UpdateBtnShow()
	{
	}

	private void ShowGameObject(GameObject pObj, bool pShow)
	{
	}

	private void UpdateNetState()
	{
	}

	private void Update()
	{
	}
}
