using UnityEngine;

public class PiggyBankEntrance : MainUIButtonBase
{
	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	[SerializeField]
	private GameObject go_Progress;

	[SerializeField]
	private DxxText txt_crtCount;

	[SerializeField]
	private GameObject go_Diamond;

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

	public void updateUI()
	{
	}

	protected override void OnClose()
	{
	}

	public override bool isRed()
	{
		return false;
	}

	public void onButtonIcon()
	{
	}
}
