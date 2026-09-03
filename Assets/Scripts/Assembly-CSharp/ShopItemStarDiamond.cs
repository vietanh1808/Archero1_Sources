using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemStarDiamond : MonoBehaviour
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Get;

	public Image Image_Icon;

	public DxxText Text_Count;

	public DxxText Text_Money;

	private Shop_Shop shopdata;

	private int mIndex;

	private string _produceId;

	public void PurchaseFly(string id, Transform t)
	{
	}

	private void PurchaseFlyInternal(string id, Transform t)
	{
	}

	private void Awake()
	{
	}

	private void OnClickButtonInternal(string productID)
	{
	}

	public void Init(int index, string productId)
	{
	}

	public void OnLanguageChange()
	{
	}
}
