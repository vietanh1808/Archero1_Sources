using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class PVERankRewardDetailItem : UITableViewCell
{
	[SerializeField]
	private DxxText ranking;

	[SerializeField]
	private Image rewardBg;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private GameObject decorateObj;

	[SerializeField]
	private Image decorate1;

	[SerializeField]
	private Image decorate2;

	private PVERankRewardDetailItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private void Init()
	{
	}

	private void InitObjectPool()
	{
	}

	public void Refresh(PVERankRewardDetailItemData data)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshStatus()
	{
	}
}
