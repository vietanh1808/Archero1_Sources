using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossPlayRewards : MonoBehaviour
{
	public Image levelBgImg;

	public DxxText levelTex;

	public GameObject slider_up;

	public GameObject slider_down;

	public Transform rewardsParent;

	public BossPlayRewardItem rewardObj;

	private List<BossPlayRewardItem> rewardItems;

	public void Init(List<string> rewards, int index, bool isLast, bool isUnLock, bool isComplete)
	{
	}
}
