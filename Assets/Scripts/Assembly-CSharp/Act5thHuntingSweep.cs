using PureMVC.Interfaces;
using UnityEngine;

public class Act5thHuntingSweep : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private Transform sweepItemParent;

	[SerializeField]
	private ButtonCtrl maskBtn;

	[SerializeField]
	private Act5thHuntingSweepItem sweepItem;

	private LocalUnityObjctPool pool;

	private Act5thHuntingManager HuntingManager => null;

	private Act5thHuntingBaseData HuntingBaseData => null;

	private void InitPool()
	{
	}

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

	public void OpenSweep()
	{
	}

	public void CloseSweep()
	{
	}

	private void RefreshItem()
	{
	}

	private void ClickMaskBtn()
	{
	}

	private void Esc()
	{
	}
}
