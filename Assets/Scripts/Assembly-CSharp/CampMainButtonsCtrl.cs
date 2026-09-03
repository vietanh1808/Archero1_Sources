using UnityEngine;
using UnityEngine.UI;

public class CampMainButtonsCtrl : MonoBehaviour
{
	private CampMainButton[] mInterfaces;

	[SerializeField]
	private RectTransform bgImg;

	[SerializeField]
	private Button openBtn;

	[SerializeField]
	private RectTransform contentParent;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private Transform arrow;

	[SerializeField]
	private RedNodeCtrl redNodeCtrl;

	[SerializeField]
	private GridLayoutGroup gridLayout;

	private bool isOpen;

	private int minShowCount;

	private int maxShowCount;

	private int ShowBgCount;

	private void Awake()
	{
	}

	public void Refresh()
	{
	}

	public void OnClickOpenBtn()
	{
	}
}
