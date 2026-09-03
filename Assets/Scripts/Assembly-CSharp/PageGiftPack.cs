using UnityEngine;
using UnityEngine.UI;

public class PageGiftPack : UserBackPageBase
{
	[SerializeField]
	private GiftPackSetItemCtrl giftPackSet;

	[SerializeField]
	private GameObject itemTemplate;

	[SerializeField]
	private RectTransform rectParent;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private StarDiamondItem starDiamondItem;

	private LocalUnityObjctPool pool;

	private void Awake()
	{
	}

	public override void UpdateUI(bool reset = false)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
