using PureMVC.Interfaces;
using UnityEngine;

public abstract class UIBase
{
	protected GameObject mView;

	protected Transform mParent;

	protected bool m_bOpenFlag;

	public UIBase(Transform parent)
	{
	}

	public void InitBefore()
	{
	}

	protected virtual void OnInitBefore()
	{
	}

	public void Init()
	{
	}

	protected abstract void OnInit();

	public void DeInit()
	{
	}

	protected abstract void OnDeInit();

	public void Open()
	{
	}

	protected abstract void OnOpen();

	public void Close()
	{
	}

	protected abstract void OnClose();

	public void HandleNotification(INotification notification)
	{
	}

	protected abstract void OnHandleNotification(INotification notification);

	public abstract void OnLanguageChange();

	public virtual object OnGetEvent(string eventName)
	{
		return null;
	}

	public virtual void PreloadRes()
	{
	}
}
