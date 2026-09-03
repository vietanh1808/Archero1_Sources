using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine.UI;

public class HuaweiVideoUICtrl : MediatorCtrlBase
{
	public Image Image_Boss;

	public Image Image_Hero;

	public DxxText Text_1;

	public DxxText Text_2;

	private bool bStartLogin;

	private bool bShowNet;

	private int mLoginSate;

	private Sequence seq;

	private Sequence seq_login;

	public ButtonCtrl startBtn;

	public bool IsLogin => false;

	protected override void OnInit()
	{
	}

	private void ShowRetry()
	{
	}

	private void OnLoginCallback_Retry()
	{
	}

	private void OnLoginCallback()
	{
	}

	private void ShowNetDoing(bool value)
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void KillSequence()
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

	public void OnClickStartBtn()
	{
	}

	private void OnLoginSuccess()
	{
	}

	private void GoToMain()
	{
	}
}
