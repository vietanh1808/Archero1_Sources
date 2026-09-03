using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class NewPlay125GameSpeedUpItem : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private Image speedUpIcon;

	private int curSpeedUpIndex;

	private bool IsSailingBagBattle => false;

	private int GetLegalSpeedUpIndex => 0;

	private float CurSpeedUp => 0f;

	private float[] AllSpeedUpGrade => null;

	private float[] AllShowSpeedUpGrade => null;

	private bool IsUnlockSpeedUp => false;

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

	private void OnClickBtn()
	{
	}

	private void OnClickDisableBtn()
	{
	}

	private void Refresh()
	{
	}

	public void RefreshCurSpeedUp()
	{
	}

	private void OnRebornTimeScale()
	{
	}
}
