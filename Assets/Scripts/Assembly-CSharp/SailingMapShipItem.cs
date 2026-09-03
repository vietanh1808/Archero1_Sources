using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SailingMapShipItem : SailingMapGoodItem
{
	public enum ShipSpeedState
	{
		None = 0,
		Stop = 1,
		Slow = 2,
		Fast = 3
	}

	public GameObject boxObj;

	public Image boxImg;

	public HeadItem headItem;

	public ButtonCtrl clickBtn;

	public GameObject rankObj;

	public DxxText rankText;

	public DxxText rankValueText;

	public Image rankBg;

	private static Queue<SailingShipOne> shipPool;

	private ShipSpeedState speedState;

	public Transform shipParent;

	public Transform effectParent;

	private SailingShipPartData _crtData;

	private SailingShipOne _shipOne;

	public static SailingShipOne GetShipOne()
	{
		return null;
	}

	public static void ClearShipPool()
	{
	}

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

	public void ClickHomePage()
	{
	}

	protected override void PlayMonsterAni(RectTransform target)
	{
	}

	private void Update()
	{
	}
}
