using UnityEngine;

public class CharUpgradeInfoCtrl : MonoBehaviour
{
	public Animator ani_window;

	public DxxText Text_Name;

	public HeroLevelInfoCtrl mLevelInfoCtrl;

	public HeroPropInfoCtrl mAtkInfoCtrl;

	public HeroPropInfoCtrl mHpInfoCtrl;

	private int lastLevelValue;

	private int lastAtkValue;

	private int lastHpValue;

	private int charid;

	private int currentTab;

	public void Init(int charid)
	{
	}

	public void showUpgradeAdd()
	{
	}

	public void showTrainAdd()
	{
	}

	private string getlevelstring()
	{
		return null;
	}

	private string getatkstring()
	{
		return null;
	}

	private string gethpmaxstring()
	{
		return null;
	}

	public void PlayLevelUp()
	{
	}

	public void playTrainUpAnimation()
	{
	}

	public void freshBehindValue()
	{
	}
}
