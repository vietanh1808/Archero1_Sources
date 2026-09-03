using UnityEngine;
using UnityEngine.UI;

public class ChallengeInfoCtrl : MonoBehaviour
{
	public DxxText Text_Title;

	public DxxText Text_SuccessContent;

	public DxxText Text_Success;

	public DxxText Text_RewardContent;

	public DxxText Text_RewardCount;

	public Image Image_RewardIcon;

	public DxxText Text_ChallengeButton;

	public ButtonCtrl Button_Challenge;

	public ChallengeConditionUICtrl mConditionUICtrl;

	private int m_ID;

	private void Awake()
	{
	}

	public void Init(int id)
	{
	}
}
