using Dxx.UI;
using UnityEngine;

public class SigninRewardOne : MonoBehaviour
{
	public DxxText TimeTitle;

	public DxxText TimeTitle2;

	public DxxText GetRewardText;

	public DxxText CountDownText;

	public GameObject content;

	public ButtonCtrl Button_GetReward;

	private LocalUnityObjctPool mPool;

	public GameObject GetReward_Image;

	private bool bWaitReceive;

	private long WaitTime;

	private int RewardId;

	private GradientAngle Gradient_bg;

	private GameObject _harvestitem;

	[SerializeField]
	private GameObject harvestitem;

	public void Init(LoginGiftOne gift, int daytime)
	{
	}

	public void CreateReward(LoginGiftOne gift)
	{
	}

	public void Close()
	{
	}

	public void GetReward()
	{
	}

	public void AfterReceive()
	{
	}

	public void WaitToGetReward(long wtime)
	{
	}

	public void NotReceive()
	{
	}

	private void Update()
	{
	}

	public void OnLanguageChange()
	{
	}
}
