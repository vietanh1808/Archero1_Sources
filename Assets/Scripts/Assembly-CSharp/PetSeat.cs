using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetSeat : MonoBehaviour
{
	public static bool isSelectingSeat;

	public static string WaitPetName;

	public int seatIndex;

	public Image rateImg;

	public RawImage petImg;

	public PetStarCtrl star;

	public GameObject plusObj;

	public GameObject showObj;

	public GameObject switchObj;

	public GameObject lockObj;

	public DxxText switchText;

	public DxxText lockLevelText;

	public DxxText lockDesc;

	public RedNodeCtrl addRedNode;

	public RedNodeCtrl levelRedNode;

	public Transform effectparent;

	protected LocalSave.PetOne mData;

	private HeroShow heroShow;

	private int petId;

	private Dictionary<int, GameObject> mChangeEffects;

	public int UnLockLevel => 0;

	public bool IsUnlock => false;

	public void Init()
	{
	}

	public virtual void OnInit()
	{
	}

	public virtual void OnClick()
	{
	}

	public void show_effect()
	{
	}

	public void UnInit()
	{
	}
}
