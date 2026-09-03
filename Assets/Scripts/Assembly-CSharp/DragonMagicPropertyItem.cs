using DG.Tweening;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class DragonMagicPropertyItem : MonoBehaviour
{
	[SerializeField]
	private DxxImage imgIcon;

	[SerializeField]
	private Image imgTweenBG;

	[SerializeField]
	private Image imgTweenHighlight;

	[SerializeField]
	private DxxText txtName;

	[SerializeField]
	private DxxText txtValue;

	private byte type;

	private float addValRatio;

	private float cachedAddValue;

	private Goods_goods.GoodData cachedGoodData;

	private float cachedEnhancePercent;

	private long cachedTotal;

	private bool isPercent;

	private float addValShown => 0f;

	public void SetCommonAttr(string attr, int dragonCurrentLevel, float addValue, float enhancePercent)
	{
	}

	private void SetCommonAttr(Goods_goods.GoodData one, int dragonCurrentLevel, float addValue, float enhancePercent)
	{
	}

	private void SetCommonAttrText()
	{
	}

	private string GetCommonValueTextArabic()
	{
		return null;
	}

	private string GetCommonValueText()
	{
		return null;
	}

	public void SetAdditionalAttr(Goods_goods.GoodData attr)
	{
	}

	private static string GetAdditionalText(long attrValue, bool attrPercent)
	{
		return null;
	}

	public void SetDragonAttr(string info)
	{
	}

	public void GetUpgradeTween(Sequence seq, int newLevel)
	{
	}
}
