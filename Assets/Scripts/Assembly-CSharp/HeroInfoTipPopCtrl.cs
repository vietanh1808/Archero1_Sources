using UnityEngine;

public class HeroInfoTipPopCtrl : MonoBehaviour
{
	public GameObject child;

	public RectTransform bgparent;

	public RectTransform arrowparent;

	public DxxText Text_Name;

	public DxxText Text_Info;

	public RectTransform left;

	public RectTransform right;

	public Animation ani;

	public void Init(string title, string desc, Vector3 worldPos, TextAnchor anchor = TextAnchor.MiddleCenter)
	{
	}

	public void Show(bool value)
	{
	}
}
