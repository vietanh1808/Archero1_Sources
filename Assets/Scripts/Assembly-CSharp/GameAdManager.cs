using System;

public sealed class GameAdManager
{
	private static GameAdManager instance;

	private static object Locker;

	public bool EggHatch_AdOpen;

	public int EggHatch_AdLeftCount;

	public long EggHatch_AdLastTime;

	public BallonSeverData ballonSeverData;

	public static GameAdManager Instance => null;

	public bool ballonIsOn => false;

	public bool ballonIsHavePurchase => false;

	public void requestGameAd(int type, ulong rowid, Action callBack = null)
	{
	}

	public bool canUseGameAd_Egg()
	{
		return false;
	}

	public void CheckCurBallonRewards()
	{
	}

	public void requestWatchAd(ADCountSource source = ADCountSource.eIrregularActivity, Action<bool> action = null)
	{
	}
}
