using UnityEngine;

public class MainUIWorldCupCtrl : MainUIButtonBase
{
	[SerializeField]
	private ButtonCtrl button;

	[SerializeField]
	private RedNodeCtrl redNode;

	[SerializeField]
	private DxxText txtCountdown;

	private float time;

	private void Awake()
	{
	}

	public void OnOpen()
	{
	}

	public new void UpdateUI()
	{
	}

	private void UpdateRedNode()
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

	private void Update()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}
}
