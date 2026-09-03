using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class ManorPanelBase : MonoBehaviour
{
	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge _c__Hotfix0_ctor;

	public virtual void OnInit()
	{
	}

	public virtual void Open()
	{
	}

	public virtual void Close()
	{
	}

	public virtual void OnLanguageChange()
	{
	}

	public virtual void OnHandleNotification(INotification notification)
	{
	}
}
