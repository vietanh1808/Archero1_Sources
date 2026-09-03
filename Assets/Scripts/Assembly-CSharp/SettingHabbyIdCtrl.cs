using HabbySdk.HabbyId;
using UnityEngine;
using UnityEngine.UI;

public class SettingHabbyIdCtrl : MonoBehaviour
{
	[SerializeField]
	private DxxText Text_HabbyId;

	[SerializeField]
	private DxxText Text_Value;

	[SerializeField]
	private ButtonCtrl Button_habbyId;

	[SerializeField]
	private Button rewardTip;

	[SerializeField]
	private Text Text_Reward_DiamondNum;

	[SerializeField]
	private GameObject goRewardPop;

	[SerializeField]
	private Transform tRewardParent;

	[SerializeField]
	private DxxText Text_Reward;

	[SerializeField]
	private Image Img_HabbyId;

	private void Awake()
	{
	}

	private void HandleLoginSuccessEvent(C2V_LoginSuccessEvent obj)
	{
	}

	internal void ChangeEntryState()
	{
	}

	internal void ResetEntryState()
	{
	}

	private void OnClickButton()
	{
	}

	internal void UpdateLanguage()
	{
	}
}
