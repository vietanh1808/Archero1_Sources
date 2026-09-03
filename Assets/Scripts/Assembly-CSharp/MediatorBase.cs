using System.Collections.Generic;
using PureMVC.Interfaces;

public class MediatorBase : WindowMediator, IMediator, INotifier
{
	public static Dictionary<string, MediatorCtrlBase> mCtrlList;

	private MediatorCtrlBase _ctrl;

	private MediatorCtrlBase ctrl => null;

	public static void Remove(string name)
	{
	}

	public MediatorBase(string path)
		: base(null)
	{
	}

	protected override void OnRegisterOnce()
	{
	}

	protected override void OnRegisterEvery()
	{
	}

	protected override void OnRemoveAfter()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnLanguageChange()
	{
	}

	public override object GetEvent(string eventName)
	{
		return null;
	}
}
