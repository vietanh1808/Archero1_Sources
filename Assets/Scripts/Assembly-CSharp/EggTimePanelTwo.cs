using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggTimePanelTwo : MonoBehaviour
{
	public EggTimeCardUICtrl uiCtrl;

	public DxxText Kill_Hatch;

	public Slider Kill_Slider;

	public DxxText Kill_Progress;

	public DxxText Time_Hatch;

	public Slider Time_Slider;

	public DxxText Time_Progress;

	public ButtonCtrl Button_Back;

	public DxxText Text_Press;

	public GameObject cpItem;

	public RectTransform Container;

	private Dictionary<int, EggTimeItem> cardDict;

	private LocalSave.EggData data;

	public UISliderTween Slider_Tween1;

	public UISliderTween Slider_Tween2;

	private int TimeTotal;

	private int TimeCut;

	private int TimeSpace;

	private int TimePass;

	private int needKill;

	private int have;

	public void OnInit()
	{
	}

	public void OnClose()
	{
	}

	public void init()
	{
	}

	private void calcuteTimex()
	{
	}

	public void onLanguageChanged()
	{
	}

	public void freshUI()
	{
	}

	public void freshCardItem(int equipid)
	{
	}
}
