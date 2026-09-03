using UnityEngine;

public class ImprintWarPart : MonoBehaviour
{
	public static int needUnLockSeadId;

	public DxxText textTitle;

	public GameObject lockObjs;

	public Animator lockani;

	public ImprintWarSeat[] seats;

	public ButtonCtrl tipsBtn;

	public ImprintTips tips;

	public void Init()
	{
	}

	public void Refresh()
	{
	}

	public void OnUpWar(int imprintId, int seatId)
	{
	}

	private void OnDownWar(int obj)
	{
	}

	public void OnReadyImprint(int imprintId)
	{
	}

	public void OnClickLock()
	{
	}

	public void DeInit()
	{
	}
}
