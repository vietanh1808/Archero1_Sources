using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WatchAdRewardOneCtrl : MonoBehaviour
{
	public DxxText titleTex;

	public ButtonCtrl ButtonGet;

	public GameObject itemone;

	public Transform itemparent;

	public DxxText descTex;

	public DxxText progressTex;

	public Slider slider;

	public DxxText btnTex;

	public Image btnImg;

	private LocalUnityObjctPool mPool;

	private bool bInit;

	private List<MainActivityOneBGCtrl> showRewardsItem;

	public void Init()
	{
	}

	public void Refresh()
	{
	}

	public void OnLanguageChange()
	{
	}
}
