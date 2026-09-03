using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroExtraShowSkill : MonoBehaviour
{
	[SerializeField]
	private HeroShowSkill normalShowSkill;

	[SerializeField]
	private DxxText normalSkillDesc;

	[SerializeField]
	private DxxText skillName;

	[SerializeField]
	private Transform extraSkillParent;

	[SerializeField]
	private HeroShowSkill skill;

	[SerializeField]
	private ContentSizeFitter contentFilter;

	private HeroShowSkillData normalData;

	private List<HeroShowSkillData> extraData;

	private LocalUnityObjctPool pool;

	private List<HeroShowSkill> createSkill;

	public void Init()
	{
	}

	private void InitObjectPool()
	{
	}

	public HeroExtraShowSkill Refresh(HeroShowSkillData normalData, List<HeroShowSkillData> extraData)
	{
		return null;
	}

	private void RefreshNormal()
	{
	}

	private void RefreshExtra()
	{
	}

	private void ResetScrollPosition()
	{
	}
}
