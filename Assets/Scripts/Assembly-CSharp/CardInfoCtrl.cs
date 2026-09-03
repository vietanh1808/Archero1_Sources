using UnityEngine;

public class CardInfoCtrl : MonoBehaviour
{
	public GameObject child;

	public RectTransform bgparent;

	public RectTransform arrowparent;

	public DxxText Text_Name;

	public DxxText Text_Info;

	public RectTransform left;

	public RectTransform right;

	public Animation ani;

	private CardOneCtrl target;

	public void Init(CardOneCtrl ctrl)
	{
	}

	public void Show(bool value)
	{
	}
}
