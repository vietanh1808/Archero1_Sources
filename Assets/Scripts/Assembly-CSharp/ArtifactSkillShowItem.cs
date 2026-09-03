using UnityEngine;
using UnityEngine.UI;

public class ArtifactSkillShowItem : MonoBehaviour
{
	public DxxText Text_Basic;

	public DxxText Text_End;

	public DxxText Text_SkillName;

	public RectTransform Content;

	public DxxText Text_SkillDesc;

	public Image Icon_SkillBG;

	public Image Icon_Skill;

	public DxxText Text_Info;

	public GameObject Tab_FocusL;

	public GameObject Tab_FocusR;

	private int currentTab;

	private LocalSave.ArtifactOne artiOne;

	public void init(LocalSave.ArtifactOne one)
	{
	}

	public void onLanguaged()
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private void freshTab(int tab)
	{
	}
}
