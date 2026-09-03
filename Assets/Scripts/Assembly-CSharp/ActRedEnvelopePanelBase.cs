using System;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public abstract class ActRedEnvelopePanelBase : MonoBehaviour
{
	private static DelegateBridge _c__Hotfix0_ctor;

	public abstract Color timeDownColor { get; }

	public abstract event Action<string> UpdateTimeDown;

	public abstract event Action RefreshTokenNum;

	public abstract void Init();

	public abstract void Open();

	public abstract void Close();

	public abstract void OnHandleNotification(INotification notification);

	public abstract void OnLanguageChange();
}
