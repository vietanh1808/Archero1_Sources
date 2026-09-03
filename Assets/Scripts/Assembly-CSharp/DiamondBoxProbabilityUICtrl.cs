using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class DiamondBoxProbabilityUICtrl : MediatorCtrlBase
{
	public enum ProbabilityType
	{
		Commont = 0,
		SBox = 1
	}

	public RectTransform window;

	public EquipProbabilityOne oneProbability;

	public GameObject content;

	public DxxText Title;

	public DxxText Title2;

	public DxxText Title3;

	public DxxText Title4;

	public DxxText Title5;

	public DxxText Title7;

	public DxxText Title8;

	public ButtonCtrl Button_Close;

	private RectTransform mTransform;

	private LocalUnityObjctPool mPool;

	private IList<Drop_DropShow> DropShowList;

	private List<Drop_DropShow> NormalDropList;

	private List<Drop_DropShow> LargeDropList;

	private List<Drop_DropShow> DropList3;

	private List<Drop_DropShow> DropList4;

	private List<Drop_DropShow> DropList5;

	private List<Drop_DropShow> DropList6;

	private List<Drop_DropShow> DropList7;

	private List<Drop_DropShow> DropList8;

	private float Title_Height;

	private float Content_Height;

	private SystemLanguage mLanguage;

	private ProbabilityType curType;

	protected override void OnClose()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnInitBefore()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	private string ChangeColor(int i, string id)
	{
		return null;
	}

	private string ChangeProbabilityColor(int i, float probability)
	{
		return null;
	}

	public override void OnLanguageChange()
	{
	}
}
