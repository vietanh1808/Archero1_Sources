using System;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public abstract class CampGuideItemBase : MonoBehaviour
{
	public enum CampGuideType
	{
		dialogue = 0,
		button = 1
	}

	protected SLG_NewHand mData;

	public bool isShowing { get; private set; }

	public abstract event Action OnEndCallBack;

	public void Init()
	{
	}

	protected virtual void OnInit()
	{
	}

	public void Open(SLG_NewHand data)
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

	public abstract CampGuideType GetGuideType();
}
