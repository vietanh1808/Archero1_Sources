using UnityEngine;

public class BattlePass_BigPropOne : BattlePass_PropOne
{
	protected enum IconType
	{
		COIN = 0,
		GEM = 1,
		KEY = 2,
		CHEST = 3,
		SKILLCARD = 4,
		COOKIE = 5,
		FRAGMENT = 6,
		EGG = 7,
		DRAGONITE = 8,
		SKIN_COUPON = 9,
		RELIC_FRAGMENT = 10,
		SKIN = 11,
		HEAD = 12,
		HEAD_FRAME = 13,
		VOID_FRAGMENT = 14,
		MOD_STONE = 15
	}

	protected struct IconMetrics
	{
		public int y;

		public int size;
	}

	public GameObject shadow;

	public bool isPremium;

	public bool isNew;

	public bool isShowBg;

	protected static readonly IconMetrics[][] metrics;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}
}
