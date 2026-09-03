using UnityEngine;
using UnityEngine.UI;

public class TradingAchievementItem : MonoBehaviour
{
	public GameObject lightTopObj;

	public GameObject lightBottomObj;

	public GameObject darkTopObj;

	public GameObject darkBottomObj;

	public GameObject hasGetObj;

	public GameObject topObj;

	public GameObject bottomObj;

	public Image levelBg;

	public TradingAchievementRewardItem RewardItem;

	public DxxText levelTex;

	public DxxText needBlood;

	public GameObject go_Receive;

	private TradingAchRewardItemData mData;

	private TradingAchRewardItemData mNextData;

	private int index;

	public void Init(TradingAchRewardItemData data, TradingAchRewardItemData nextData, int _index)
	{
	}

	public void Refresh()
	{
	}
}
