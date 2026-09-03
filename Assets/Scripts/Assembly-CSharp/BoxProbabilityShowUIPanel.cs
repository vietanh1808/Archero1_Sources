using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class BoxProbabilityShowUIPanel : MediatorCtrlBase
{
	public enum ProbabilityType
	{
		Common = 0,
		SBox = 1
	}

	public DxxText Text_Title;

	public ButtonCtrl btn_Close;

	public RectTransform rect_Parent;

	public ScrollRect scroll;

	public BoxProbabilityShowItem item;

	public BoxProbabilityShowTitleItem titleItem;

	public ButtonCtrl btnTab1;

	public ButtonCtrl btnTab2;

	public DxxText txtTab1;

	public DxxText txtTab2;

	public DxxText txtUnSelectTab1;

	public DxxText txtUnSelectTab2;

	public GameObject goTab1Selected;

	public GameObject goTab2Selected;

	public DxxText txtInfo;

	private ProbabilityType mBoxType;

	private List<Probability_Box> DiamondLargeBox;

	private List<Probability_Box> DiamondNormal;

	private List<Probability_Box> MixBox;

	private List<Probability_Box> DragonBox;

	private List<Probability_Box> RelicsBox;

	private List<Probability_Box> ManorBox;

	private List<Probability_Box> PetBox;

	private List<Probability_Box> ImprintBox;

	private List<Probability_Box> EquipSBox;

	private List<Probability_DropShow> allDrops;

	private LocalUnityObjctPool _pool;

	private int tabIndex;

	private List<BoxProbabilityShowItem> _allLoadCell;

	protected override void OnInit()
	{
	}

	private int SortBox(Probability_Box a, Probability_Box b)
	{
		return 0;
	}

	protected override void OnOpen()
	{
	}

	private void RefreshUI()
	{
	}

	private void OnBtnTabClick(int tIndex)
	{
	}

	protected override void OnClose()
	{
	}

	private void LoadCell(List<Probability_Box> boxData, bool isShowTitle = false)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnBtnCLose()
	{
	}
}
