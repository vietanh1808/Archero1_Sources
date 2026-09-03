using PureMVC.Interfaces;
using UnityEngine;

public class OfficialStoreBannerCtrl : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private DxxText _textOfficialStoreTips;

	[SerializeField]
	private DxxText _textOfficialStore;

	[SerializeField]
	private ButtonCtrl _btnOfficialStore;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}
}
