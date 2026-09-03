using TableTool;
using UnityEngine;

public class ActiveDiffCtrl : MonoBehaviour
{
	public DxxText Text_Diff;

	public DxxText Text_Attack;

	public DxxText Text_Unlock;

	public GoldTextCtrl mKeyCtrl;

	public GameObject unlockobj;

	public GameObject lockobj;

	public ButtonCtrl mButton;

	private int mIndex;

	private Stage_Level_activity mData;

	private void Awake()
	{
	}

	public void Init(int index, Stage_Level_activity data)
	{
	}

	private void OnClickButton()
	{
	}
}
