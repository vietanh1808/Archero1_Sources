using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class DropUpTaskItem : MonoBehaviour
{
	public GameObject bg;

	public GameObject completedAward_bg;

	public ButtonCtrl FinishTask_Button;

	public RectTransform content;

	public DxxText completeText;

	public DxxText taskText;

	public DxxText finishTaskText;

	public DxxText underWayText;

	public GameObject underWay;

	public Slider slider;

	public uint needbattle;

	public uint nProcess;

	private int index;

	private float ratio;

	private float intervalx;

	private LocalUnityObjctPool mPool;

	private GameObject _harvestitem;

	private DropUpPropType dropUpType;

	private DropUpPropData CurTypeDropUpData => null;

	private GameObject harvestitem => null;

	public void Init(CActivityDropRateTask taskdata, DropUpPropType dropUpType)
	{
	}

	public void Close()
	{
	}

	public void CreateReward(CRewardItem[] rewards)
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

	public void OnLanguageChange()
	{
	}
}
