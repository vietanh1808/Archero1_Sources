using UnityEngine;

public class SailingMapPirateGiftShipItem : SailingMapGoodItem
{
	public enum ShipSpeedState
	{
		None = 0,
		Stop = 1,
		Slow = 2,
		Fast = 3
	}

	private ShipSpeedState speedState;

	public Transform effectParent;

	private void Awake()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnRefresh()
	{
	}

	protected override void OnUnInit()
	{
	}

	private void RefreshEffect()
	{
	}
}
