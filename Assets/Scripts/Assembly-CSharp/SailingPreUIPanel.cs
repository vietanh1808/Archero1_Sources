using PureMVC.Interfaces;
using UnityEngine;

public class SailingPreUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_TimeTips;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Reward;

	public DxxText Text_Reward;

	public ButtonCtrl Button_Task;

	public DxxText Text_Task;

	public ButtonCtrl Button_SignUp;

	public DxxText Text_SignUp;

	public GameObject RedPoint;

	public ButtonCtrl Button_Info;

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

	private void onButtonClose()
	{
	}

	private void initUI()
	{
	}

	private void setButtonState()
	{
	}

	private void onButtonTask()
	{
	}

	private void onButtonSignUp()
	{
	}

	private void onButtonReward()
	{
	}

	private void freshTime()
	{
	}

	public void onButtonCloseWindow()
	{
	}

	private void freshRedPoint()
	{
	}

	private void onButtonInfo()
	{
	}
}
