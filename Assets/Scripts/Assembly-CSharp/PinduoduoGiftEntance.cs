using UnityEngine;

public class PinduoduoGiftEntance : MainUIButtonBase
{
	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private RedNodeCtrl redCtrl;

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

	private void freshTime()
	{
	}

	protected override void OnClose()
	{
	}

	public void updateUI()
	{
	}

	public override bool isRed()
	{
		return false;
	}
}
