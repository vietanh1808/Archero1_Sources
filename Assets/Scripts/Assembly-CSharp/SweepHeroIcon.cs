using System;
using UnityEngine;
using UnityEngine.UI;

public class SweepHeroIcon : MonoBehaviour
{
	public ButtonCtrl Button_Icon;

	public Image Image_Locker;

	public Image Image_Icon;

	public Material Mat_Gray;

	private HeroTrainLevelDropData htData;

	private Action<HeroTrainLevelDropData, Vector3> action;

	public void Awake()
	{
	}

	public bool initHeroIcon(HeroTrainLevelDropData htldd, Action<HeroTrainLevelDropData, Vector3> action)
	{
		return false;
	}

	public void SetHeroIcon(int heroId)
	{
	}

	public void onButtonIcon()
	{
	}
}
