using System;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public abstract class SailingGuideItemBase : MonoBehaviour
{
	public enum GuideType
	{
		dialogue = 0,
		button = 1
	}

	protected ShipBattle_NewHand mData;

	public bool isShowing { get; private set; }

	public abstract event Action OnEndCallBack;

	public void Init()
	{
	}

	protected virtual void OnInit()
	{
	}

	public void Open(ShipBattle_NewHand data)
	{
	}

	protected abstract void OnOpen();

	public void Close()
	{
	}

	protected virtual void OnClose()
	{
	}

	public virtual void OnHandleNotification(INotification notification)
	{
	}

	public virtual void OnLanguageChange()
	{
	}

	public abstract GuideType GetGuideType();
}
