using System;
using Newtonsoft.Json;

[Serializable]
public class NewPlay126SkillItemData
{
	public int SkillID;

	public float CDTime;

	public float CurCumulativeTime;

	public float BanTime;

	public float CurCumulativeBanTime;

	public NewPlay126SkillStatus SkillStatus;

	[JsonIgnore]
	public NewPlay126SkillType SkillType => NewPlay126SkillType.None;

	public bool IsSkillInStatus(NewPlay126SkillStatus skillStatus)
	{
		return false;
	}

	public static NewPlay126SkillItemData Create(int skillID, float cdTime, float cumulativeTime, float banTime, NewPlay126SkillStatus skillStatus)
	{
		return null;
	}

	public void UpdateCD(float delta)
	{
	}

	public float GetCDTime()
	{
		return 0f;
	}

	public void CastSkill()
	{
	}

	public void ResetSkill()
	{
	}

	private bool IsInStatus(NewPlay126SkillStatus status)
	{
		return false;
	}

	private void AddStatus(NewPlay126SkillStatus status)
	{
	}

	private void RemoveStatus(NewPlay126SkillStatus status)
	{
	}

	private void ResetPetStatus()
	{
	}
}
