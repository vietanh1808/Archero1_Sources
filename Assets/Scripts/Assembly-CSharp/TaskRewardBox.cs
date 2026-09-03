using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class TaskRewardBox : MonoBehaviour
{
	public const string BoxAniString = "BoxChestRotating";

	[SerializeField]
	private RectTransform rewardRoot;

	[SerializeField]
	private PropOneEquip item;

	[SerializeField]
	private Image imgBox;

	[SerializeField]
	private GameObject reward;

	[SerializeField]
	private DxxText rewardText;

	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private Animation anim;

	private int index;

	private bool interacting;

	private bool press;

	private bool longpress;

	private float presstime;

	private Achieve_WeeklyTaskReward rewardCfg;

	[SerializeField]
	private Sprite sOpen;

	[SerializeField]
	private Sprite sClosed;

	private TaskWeeklyUICtrl taskWeeklyUICtrl;

	private Camera uiCamera;

	private WeeklyTaskMgr.BoxStatus boxStatus => WeeklyTaskMgr.BoxStatus.CanGet;

	private void Awake()
	{
	}

	public void OnPointerDown()
	{
	}

	private void Update()
	{
	}

	public void HideReward()
	{
	}

	public void Init(TaskWeeklyUICtrl ctrl, int index)
	{
	}
}
