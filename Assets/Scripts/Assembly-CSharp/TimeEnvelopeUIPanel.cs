using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;

public class TimeEnvelopeUIPanel : MediatorCtrlBase
{
	public GameObject Fly;

	public UGUISpriteAnimation Envelope;

	public DxxText Text_Info;

	private bool isOpening;

	private Sequence envelopeSeq;

	private Sequence openSeq;

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

	public void onButtonTouchScreen()
	{
	}

	private void flyEnvelope()
	{
	}

	private void openEnvelope()
	{
	}
}
