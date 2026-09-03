using DG.Tweening;
using PureMVC.Interfaces;
using TableTool;

public class BoxOpenOneUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public BoxOpenOneCurrencyCtrl mCurrencyCtrl;

	public BoxOpenOneEquipCtrl mEquipCtrl;

	private int state;

	private Drop_DropModel.DropData mTransfer;

	private Sequence seq;

	private Sequence seq_close;

	protected override void OnInit()
	{
	}

	private void CloseUI()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void DelayClose()
	{
	}

	private void OnClickButton()
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
}
