using UnityEngine;

public class StageListOneCtrl : MonoBehaviour
{
	public GameObject commonparent;

	public GameObject commingparent;

	public DxxText Text_CommingSoon;

	public DxxText Text_Content;

	public DxxText Text_Stage;

	public DxxText Text_Info;

	public DxxText Text_Level;

	public GameObject lockimage;

	public GameObject stageparent;

	public StageListSkillsCtrl mSkillsCtrl;

	private GameObject stageitem;

	private int stageId;

	private bool unlock;

	private bool bCommingSoon;

	public void Init(int stage, bool unlock)
	{
	}

	private void InitStage()
	{
	}

	private void OnDestroy()
	{
	}
}
