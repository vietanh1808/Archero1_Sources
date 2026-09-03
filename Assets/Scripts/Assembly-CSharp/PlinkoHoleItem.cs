using UnityEngine;
using UnityEngine.UI;

public class PlinkoHoleItem : MonoBehaviour
{
	public PropOneEquip propItem;

	public DxxText Text_Count;

	public Image Image_Shine;

	public ParticleSystem effect_Normal;

	public ParticleSystem effect_BigReward;

	public PlinkoHoleItemData showData;

	public void init(PlinkoHoleItemData data)
	{
	}

	public bool ballDropHole_Step1()
	{
		return false;
	}

	public bool ballDropHole_Step2()
	{
		return false;
	}

	public void PlayTextEffect()
	{
	}

	public void playAniSwitch()
	{
	}

	public void showPropNumAB()
	{
	}
}
