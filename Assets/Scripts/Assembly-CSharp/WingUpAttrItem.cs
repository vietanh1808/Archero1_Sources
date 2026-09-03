using UnityEngine;
using UnityEngine.UI;

public class WingUpAttrItem : MonoBehaviour
{
	public Animator effectAni;

	public Transform starParent;

	public GameObject allObj;

	public DxxText allTex;

	public DxxText attrTex;

	public Image bgImg;

	public RectTransform RTF;

	public RectTransform RTF1;

	public GameObject levelConditionObj;

	public GameObject lockObj;

	public GameObject unlockObj;

	public DxxText lockLevelTex;

	public DxxText unlockTex;

	private LocalSave.WingOne WingOne;

	private bool isStar;

	private int condition;

	private string entry;

	private bool isUnLock;

	public void Open(LocalSave.WingOne wing, bool isStar, int condition, string entry)
	{
	}

	public void Refresh()
	{
	}

	public void RefreshDesc()
	{
	}

	public void OnLevelUp()
	{
	}

	public void OnStarUp()
	{
	}

	public void RegistEnent()
	{
	}

	public void UnRegistEvent()
	{
	}

	public void Close()
	{
	}
}
