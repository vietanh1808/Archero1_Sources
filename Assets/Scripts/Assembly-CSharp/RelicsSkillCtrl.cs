using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class RelicsSkillCtrl : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl mBtnRelicsSkill;

	[SerializeField]
	private Image mImgRelicsSkill;

	[SerializeField]
	private Image mImgRelicsSkillBorder;

	[SerializeField]
	private Image mImgRelicsSkillTimer;

	[SerializeField]
	private DxxText mTextRelicsSkillTimer;

	private RelicsSkillModelCD m_Model;

	private Relics_Relics m_Data;

	public ButtonCtrl BtnRelicsSkill => null;

	public void Init(Relics_Relics data)
	{
	}

	public void DeInit()
	{
	}

	private void OnRelicWuKongAIEndAction()
	{
	}

	private void Update()
	{
	}
}
