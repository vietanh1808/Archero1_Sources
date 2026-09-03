using PureMVC.Interfaces;
using UnityEngine;

public class ImprintCtrl : MonoBehaviour, ImprintUICtrl.IPanelBase
{
	public ImprintWarPart m_WarPart;

	public ImprintListPart m_ListPart;

	public ImprintAttributePart m_AttributePart;

	private bool isExitSelect;

	private int startIndex;

	public void Init()
	{
	}

	public void Open()
	{
	}

	public void Refresh()
	{
	}

	public void Close()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void Update()
	{
	}
}
