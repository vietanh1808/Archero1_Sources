using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class SuperRouletteTaskItemOne : MonoBehaviour
{
	public GameObject bg;

	public GameObject completedAward_bg;

	public ButtonCtrl FinishTask_Button;

	public DxxText completeText;

	public DxxText taskText;

	public DxxText finishTaskText;

	public DxxText underWayText;

	public DxxText rewardText;

	public GameObject underWay;

	public Slider slider;

	private int index;

	public void Init(CActivitySuperRouletteTask taskdata)
	{
	}

	public void GetReward()
	{
	}

	public void AfterReceive()
	{
	}

	public void NoReceive()
	{
	}

	private void OnLanguageChange()
	{
	}
}
