using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TradingHouseLogPanel : MonoBehaviour
{
	public DxxText titleTex;

	public DxxText DescText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgBtn;

	public RectTransform content;

	public TradingHouseLogItem logItem;

	public ContentSizeFitter contentSize;

	public VerticalLayoutGroup verticalLayout;

	private List<TradingHouseLogItem> logItems;

	private List<IGrouping<long, TradingHouseLogData>> logs;

	private TimeLineContainer timeLine;

	public void Init()
	{
	}

	public void Open()
	{
	}

	private void Refresh()
	{
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}
}
