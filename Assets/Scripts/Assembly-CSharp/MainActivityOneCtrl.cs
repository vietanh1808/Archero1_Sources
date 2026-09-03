using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class MainActivityOneCtrl : MonoBehaviour
{
	public DxxImage Image_BG;

	public ButtonCtrl Button_Buy;

	public DxxText Text_Buy;

	public DxxText Text_Title;

	public DxxText Text_LastTime;

	public GameObject itemparent;

	public GameObject itemone;

	public DxxText Text_GoldBefore;

	public Image Image_Line;

	public DxxText Text_Crit;

	public DxxText Text_Value;

	public GameObject discount;

	private const float OneWidth = 160f;

	private const float Text_GoldBeforeWidth = 70f;

	private LocalUnityObjctPool mPool;

	private LocalSave.MainActivityDataOne data;

	private bool bInit;

	private string timestring;

	private void init()
	{
	}

	public static void OnPurchaseSuccess(int productid, CRespInAppPurchase response)
	{
	}

	public void Init(LocalSave.MainActivityDataOne data)
	{
	}

	public void UpdateTime()
	{
	}

	public void OnClose()
	{
	}

	private void OnLanguageChange()
	{
	}

	private string GetCurrentLanguage()
	{
		return null;
	}
}
