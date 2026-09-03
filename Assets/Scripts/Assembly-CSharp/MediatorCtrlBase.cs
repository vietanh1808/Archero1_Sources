using PureMVC.Interfaces;
using UnityEngine;

public abstract class MediatorCtrlBase : MonoBehaviour
{
	public object mData;

	public bool ExcuteScale;

	protected bool bInitSize;

	protected WindowID mWindowID;

	protected virtual void OnInitBefore()
	{
	}

	public void Init()
	{
	}

	protected virtual void OnInit()
	{
	}

	protected void SetRectTransformAll()
	{
	}

	public void SetArgs(object o)
	{
	}

	protected virtual void OnSetArgs(object o)
	{
	}

	public void Open()
	{
	}

	protected virtual void OnOpen()
	{
	}

	public void Close()
	{
	}

	protected virtual void OnClose()
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void OnDeInit()
	{
	}

	public virtual void OnHandleNotification(INotification notification)
	{
	}

	public abstract void OnLanguageChange();

	public virtual object OnGetEvent(string eventName)
	{
		return null;
	}
}
