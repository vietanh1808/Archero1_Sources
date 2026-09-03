using Dxx.UI;
using UnityEngine;

public class ImprintInfoAttributeItem : MonoBehaviour
{
	public class AttrInfo
	{
		public string desc;

		public int rare;

		public bool isUnLock;

		public float add;
	}

	public DxxText descText;

	public OutLineDxx outLine;

	public DxxImage starImage;

	private AttrInfo info;

	public void SetInfo(AttrInfo _info)
	{
	}

	public void refresh()
	{
	}

	public void DeInit()
	{
	}
}
