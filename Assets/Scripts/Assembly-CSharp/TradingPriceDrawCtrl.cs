using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradingPriceDrawCtrl : MonoBehaviour
{
	public ButtonCtrl[] btn_Tab;

	public DxxImage[] icon_Selected;

	public DxxImage[] icon_UnSelected;

	public DxxText[] text_Tab;

	[Header("数据")]
	public int[] priceData;

	public string[] timeLabels;

	[Header("图表设置")]
	public GraphStyle graphStyle;

	public Vector2 chartSize;

	public Vector2 chartPadding;

	[Header("轴设置")]
	public int yAxisValueCount;

	public int xAxisDisplayCount;

	[Header("参考对象")]
	public RectTransform chartContainer;

	public GameObject pointPrefab;

	public GameObject linePrefab;

	public GameObject tickPrefab;

	public Text labelPrefab;

	public DxxText buyCount;

	public DxxText XLableContent;

	public DxxText noPriceTips;

	private List<GameObject> chartElements;

	private int minPrice;

	private int maxPrice;

	private TradingChatTab _crtTab;

	private int _propID;

	private const int FirstSizeRate = 4;

	private int DailyPriceCount => 0;

	private int HistoryPriceCount => 0;

	private TradingHouseMgr TMgr => null;

	public void OnInit()
	{
	}

	public void OnOpen(int equipID)
	{
	}

	public void OnBtnTabClick(TradingChatTab tab)
	{
	}

	public void RefreshPrice()
	{
	}

	public void OnLanguageChanged()
	{
	}

	public void DrawChart()
	{
	}

	private void CalculatePriceRange()
	{
	}

	private void DrawAxes()
	{
	}

	private void DrawYAxisPriceTicks()
	{
	}

	private void DrawXAxisTimePoints()
	{
	}

	private void DrawPriceLineAndPoints()
	{
	}

	private void CreatePoint(Vector2 position, int index)
	{
	}

	private void CreateLine(Vector2 startPos, Vector2 endPos, int index)
	{
	}

	private int GetPriceRange()
	{
		return 0;
	}

	public void ClearChart()
	{
	}

	public void UpdateData(int[] newPrices, string[] newTimes = null)
	{
	}

	public void UpdateYAxisValueCount(int count)
	{
	}

	public void UpdateXAxisDisplayCount(int count)
	{
	}

	public void UpdateStyle(GraphStyle newStyle)
	{
	}

	public void SetXAxisVisible(bool visible)
	{
	}

	public void SetXTicksVisible(bool visible)
	{
	}

	public void SetXLabelsVisible(bool visible)
	{
	}

	public void SetYAxisVisible(bool visible)
	{
	}

	public void SetYTicksVisible(bool visible)
	{
	}

	public void SetYLabelsVisible(bool visible)
	{
	}

	public void SetPointsVisible(bool visible)
	{
	}

	public void SetLinesVisible(bool visible)
	{
	}
}
