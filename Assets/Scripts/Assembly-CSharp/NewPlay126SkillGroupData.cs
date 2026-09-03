using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class NewPlay126SkillGroupData : LocalSave.ICloneable<NewPlay126SkillGroupData>
{
	public List<NewPlay126SkillItemData> SkillItems;

	[JsonIgnore]
	private bool haveInit;

	public void Clone(NewPlay126SkillGroupData source)
	{
	}

	public void Init(bool isNewGame)
	{
	}

	public void Clear()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	public void AddSkillItem(NewPlay126SkillItemData skillItemData)
	{
	}

	public void ResetAllSkill()
	{
	}
}
