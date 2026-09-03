using System;
using UnityEngine;

public class HolyLightBigRewardItem : MonoBehaviour
{
	public PropOneEquip oneEquip;

	public DxxText timesText;

	public GameObject maskObj;

	private HolyLightMgr.HolyLightPrizeConfig mConfig;

	public Action<Vector3, HolyLightMgr.HolyLightPrizeConfig> onClick;

	public void Init(HolyLightMgr.HolyLightPrizeConfig config)
	{
	}
}
