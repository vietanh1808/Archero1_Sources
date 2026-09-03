using UnityEngine;
using UnityEngine.UI;

public class SkillButtonCtrl : MonoBehaviour
{
	public DxxText text;

	public Image image;

	public Image bg;

	public Material grayMat;

	public GameObject fg;

	public int skillid { get; private set; }

	public int index { get; private set; }

	public void Init(int skillid)
	{
	}

	public void Init(int skillid, int index)
	{
	}

	public void SetIndex(int index)
	{
	}

	public void SetText(string name)
	{
	}

	public void OnClick()
	{
	}

	public void Disable()
	{
	}
}
