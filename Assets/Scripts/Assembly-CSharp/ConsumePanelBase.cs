using ActivityConsumeCommon;
using PureMVC.Interfaces;
using UnityEngine;

public class ConsumePanelBase : MonoBehaviour
{
	public ActConsumeCommonUICtrl ctrl;

	public virtual void Open()
	{
	}

	public virtual void Close()
	{
	}

	public virtual void Init(ActConsumeCommonUICtrl ctrl, ConsumeTab tab)
	{
	}

	public virtual void Refresh()
	{
	}

	public virtual void OnLanguageChange()
	{
	}

	public virtual void OnHandleNotification(INotification notification)
	{
	}
}
