using System;
using UnityEngine;

public class HolyLightDetailsSkillItem : MonoBehaviour
{
	public PauseUISkillIconCtrl skillIconCtrl;

	public ButtonCtrl clickBtn;

	public GameObject maskObj;

	public DxxText skillDesc;

	public Action<Vector3, int> onClick;

	public void Init(HolyLightAllRewardItemData data)
	{
	}
}
