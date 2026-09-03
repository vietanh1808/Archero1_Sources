using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class BeliefSkillItemData
{
	private BeliefSkillItemConfigData ConfigData { get; set; }

	public int Status => 0;

	public BeliefTalentLineDir LineDir => BeliefTalentLineDir.None;

	public BeliefTalentLineDir LineCanUpGrade => BeliefTalentLineDir.None;

	private Imprint_BeliefSkill SkillModel => null;

	public int ID => 0;

	public Sprite SkillIcon => null;

	public Sprite LockFrameIcon => null;

	public Sprite UnlockFrameIcon => null;

	public int Stage => 0;

	public int Layer => 0;

	public int TalentNum => 0;

	public List<Drop_DropModel.DropData> Rewards => null;

	public int[] PreID => null;

	public int ShowType => 0;

	public int Type => 0;

	public bool IsStageEnd => false;

	public string[] TypeParam => null;

	public string SkillDesc => null;

	public string[] Language => null;

	public string TitleDesc => null;

	public (int, int) Pos => default;

	public static BeliefSkillItemData Create(BeliefSkillItemConfigData configData)
	{
		return null;
	}

	private string GetSkillDesc()
	{
		return null;
	}

	private (int, int) GetPos()
	{
		return default;
	}

	private Sprite GetSkillIcon()
	{
		return null;
	}

	public BeliefTalentLineDir IsLineUpGrade()
	{
		return BeliefTalentLineDir.None;
	}
}
