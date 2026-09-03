using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ChooseMonsterBuffOneCtrl : ChooseSkillOneCtrl
{
	[SerializeField]
	private Image icon;

	private DxxText m_textEffect;

	private Skill_slotin_dungeon m_data;

	public virtual void Init(int skillid, DxxText name, DxxText effect, ChooseSkillProxy.ChooseSkillType type)
	{
	}

	protected override void UpdateIcon()
	{
	}

	protected override void OnScrollEnd(int id)
	{
	}
}
