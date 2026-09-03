using TableTool;
using UnityEngine;

public class AffinityItemCtrl : MonoBehaviour
{
	public delegate bool IsAffinityDelegate(int[] ids);

	public DxxText AttrDesc;

	public RectTransform HeaderParent;

	public DxxImage SelectImg;

	public DxxImage CopyOne;

	public DxxImage Bg;

	private static Material SelectedMat;

	private static Material UnSelectedMat;

	private const string Color = "_Color";

	public AffinityItemCtrl Init(Daily_HeroDefenceAffinity data, IsAffinityDelegate callback)
	{
		return null;
	}

	public void OnLanguageChange()
	{
	}
}
