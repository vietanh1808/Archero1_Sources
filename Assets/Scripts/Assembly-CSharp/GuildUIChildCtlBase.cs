using PureMVC.Interfaces;
using UnityEngine;

public class GuildUIChildCtlBase : MonoBehaviour
{
	public virtual void OnInit()
	{
	}

	public virtual void OnOpen()
	{
	}

	public virtual void OnClose()
	{
	}

	public virtual void OnLanguageChange()
	{
	}

	public virtual void OnHandleNotification(INotification notification)
	{
	}
}
