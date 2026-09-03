using TableTool;
using UnityEngine;

public class RelicsSkillUICtrl : MonoBehaviour
{
	private const string Tag = "RelicsSkillUICtrl";

	[SerializeField]
	private RelicsSkillCtrl[] mRelicsSkillCtrls;

	public RelicsSkillCtrl[] RelicsSkillCtrls => null;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void UpdateUI()
	{
	}

	private bool CheckActiveSkillCondition(Relics_Relics bean)
	{
		return false;
	}
}
