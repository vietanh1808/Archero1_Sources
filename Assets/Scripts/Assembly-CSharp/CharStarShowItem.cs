using UnityEngine;
using UnityEngine.UI;

public class CharStarShowItem : MonoBehaviour
{
	public GameObject StarObj;

	public GameObject SunObj;

	public Material GrayMat;

	private GameObject[] _starParents;

	private Image[] Stars;

	private Image[] Suns;

	private int style;

	private int arrived;

	private GameObject ShowObj;

	private GameObject[] ShowItemParents;

	private Image[] ShowItems;

	private string showPic;

	private string showPicBlank;

	public void Awake()
	{
	}

	private void GetItems()
	{
	}

	private void checkItems(int star)
	{
	}

	public void init(int star, bool gray = false)
	{
	}

	public void initWithBlank(int star)
	{
	}

	public void doAnimation()
	{
	}
}
