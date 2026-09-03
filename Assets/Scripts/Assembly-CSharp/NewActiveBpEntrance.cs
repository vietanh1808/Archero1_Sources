using Activity;
using UnityEngine;
using UnityEngine.UI;

public class NewActiveBpEntrance : MainUIButtonBase
{
	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl clickBtn;

	public Image entranceIcon;

	public DxxText txtTime;

	private long _showTime;

	private Tab _openTab;

	private void Awake()
	{
	}

	public override bool IsShow()
	{
		return false;
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	public override void UpdateUI()
	{
	}

	private void freshTime()
	{
	}

	protected override void OnClose()
	{
	}

	public void TryOpen()
	{
	}

	private void RefreshRedNode()
	{
	}
}
