using UnityEngine;
using UnityEngine.UI;

public class MonopolyAchItem : MonoBehaviour
{
	public GameObject lightTopObj;

	public GameObject lightBottomObj;

	public GameObject darkTopObj;

	public GameObject darkBottomObj;

	public GameObject hasGetObj;

	public GameObject topObj;

	public GameObject bottomObj;

	public Image levelBg;

	public MonopolyAchRewardItem RewardItem;

	public DxxText levelTex;

	public DxxText needBlood;

	private MonopolyAchRewardItemData mData;

	private MonopolyAchRewardItemData mNextData;

	private int index;

	public void Init(MonopolyAchRewardItemData data, MonopolyAchRewardItemData nextData, int _index)
	{
	}

	public void Refresh()
	{
	}
}
