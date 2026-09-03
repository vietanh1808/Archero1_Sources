using UnityEngine;

public class RewardItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private PropOneEquip equip;

	[SerializeField]
	private GameObject go_Refresh;

	private SelectKey rewardKey;

	public void SetData(int[] optional, SelectKey key)
	{
	}
}
