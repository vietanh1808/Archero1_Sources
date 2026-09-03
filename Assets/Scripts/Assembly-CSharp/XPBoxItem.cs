using DG.Tweening;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class XPBoxItem : MonoBehaviour
{
	public Image box_image;

	public RectTransform rectImage;

	public ButtonCtrl get_button;

	public GameObject award;

	public RectTransform rectaward;

	public Animation BoxAni;

	public DxxText descTex;

	[SerializeField]
	private PropOneEquip item;

	private AwardsItemOne awardOne;

	private AwardsItemOne awardTwo;

	private Vector2 ImagePosition;

	private Sequence seq;

	private bool longpress;

	private bool press;

	private bool bget;

	private bool breceived;

	private bool canclick;

	private ushort m_nLevel;

	private bool isShowingTips;

	private bool ifInit;

	private float presstime;

	private float levelUpTime;

	private TaskDailyUICtrl ctrl;

	private Camera uiCamera;

	private Achieve_DailyTaskReward reward;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public void Init(TaskDailyUICtrl taskDailyUICtrl, Achieve_DailyTaskReward reward)
	{
	}

	public void HideAward()
	{
	}

	public void ResetSequence()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void InitFinishXP()
	{
	}

	public void CanGetReward()
	{
	}

	public void CanNotGetReward()
	{
	}

	private void freshBox()
	{
	}

	public void RefreshAnimation()
	{
	}

	private void onButtonClick()
	{
	}
}
