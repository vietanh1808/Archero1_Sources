using UnityEngine;
using UnityEngine.UI;

public class HeroShowSkill : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private GameObject lockObj;

	[SerializeField]
	private Image skillIcon;

	[SerializeField]
	private Image skillBg;

	private HeroShowSkillData data;

	private float tipOffset;

	private bool isShowSkillDetail;

	private string tipDesc;

	public HeroShowSkill Refresh(HeroShowSkillData data)
	{
		return null;
	}

	public HeroShowSkill SetTipOffset(float tipOffset)
	{
		return null;
	}

	public HeroShowSkill SetTipShowSkillDetail(bool isShowSkillDetail)
	{
		return null;
	}

	public HeroShowSkill SetBtnEnable(bool enable)
	{
		return null;
	}

	public HeroShowSkill SetTipDesc(string desc)
	{
		return null;
	}

	private void Click()
	{
	}
}
