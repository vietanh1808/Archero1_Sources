using UnityEngine;
using UnityEngine.UI;

public class SailingPreSignItem : MonoBehaviour
{
	public ScrollRect scrollRect;

	public Image ScrollImage;

	public RectTransform Content;

	public GameObject cpItem;

	private int minShow;

	public DxxText Text_Count;

	public Button Button_Get;

	public ButtonCtrl Button_Diamond;

	public DxxText Text_Diamond;

	public GameObject BoxObj;

	public GameObject Locker;

	public GameObject Checker;

	public DxxText Text_ID;

	public GameObject LineT;

	public GameObject LineTLight;

	public GameObject LineB;

	public GameObject LineBLight;

	public GameObject LineRow;

	public GameObject LineSep;

	public GameObject Mask;

	private SailingPreSignItemData itemData;

	private int arrived;

	private int total;

	public void Awake()
	{
	}

	public void init(SailingPreSignItemData data, int arrived, int total)
	{
	}

	public void freshItem(int arrived)
	{
	}

	public void onButtonClick()
	{
	}

	private void onButtonBuy()
	{
	}
}
