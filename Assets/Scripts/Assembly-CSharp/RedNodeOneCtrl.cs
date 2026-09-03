using UnityEngine;
using UnityEngine.UI;

public class RedNodeOneCtrl : MonoBehaviour
{
	public RectTransform child;

	public DxxText text_count;

	public Image image;

	public Image image_icon;

	public Animator ani;

	public int count;

	private RedNodeType mType;

	public int Value
	{
		set
		{
		}
	}

	private bool CanSetText => false;

	public void SetText(string value)
	{
	}

	private void SetAniEnable(bool value)
	{
	}

	public void SetType(RedNodeType type)
	{
	}

	public void OnLanguageChange()
	{
	}
}
