using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class BoxProbabilityShowItem : MonoBehaviour
{
	public DxxText text_Probability;

	public DxxText text_Title;

	public DxxImage img_Qua;

	public DxxImage img_QuaBg;

	public BoxProbabilityShowDropItem template;

	public RectTransform rect_Parent;

	private LocalUnityObjctPool _pool;

	private Probability_Box bData;

	private bool _isInit;

	public void Init(Probability_Box data, int tabIndex, List<Probability_DropShow> drops)
	{
	}

	public void ResetProbabilityShow(int tabIndex)
	{
	}

	private void InitItem(List<Probability_DropShow> drops, int tabIndex)
	{
	}
}
