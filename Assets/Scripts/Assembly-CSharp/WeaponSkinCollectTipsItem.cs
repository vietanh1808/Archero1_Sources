using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class WeaponSkinCollectTipsItem : MonoBehaviour
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtRewardCount1;

	[SerializeField]
	private DxxText txtRewardCount2;

	[SerializeField]
	private WeaponSkinCollectTipsRewardProp propTemplate;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private DxxImage imgProp1;

	[SerializeField]
	private DxxImage imgProp2;

	private LocalUnityObjctPool _pool;

	private bool _isInit;

	private int _quality;

	private List<Drop_DropModel.DropData> _rewards;

	public void Init(int quality, bool isColor)
	{
	}

	private void LoadProps(bool isColor)
	{
	}

	private void RefreshLayout()
	{
	}

	private void RefreshRewards()
	{
	}
}
