using UnityEngine;

public class DragonMagicSkillIcon : MonoBehaviour
{
	[SerializeField]
	private DxxImage imgIcon;

	[SerializeField]
	private DxxImage imgLevelBG;

	[SerializeField]
	private DxxText txtLvl;

	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private DragonMagicDetailUICtrl ctrl;

	[SerializeField]
	private GameObject goLvl;

	[SerializeField]
	private GameObject goRim;

	[SerializeField]
	private GameObject goConnect;

	[SerializeField]
	private Sprite[] sprites;

	private int index;

	private void Awake()
	{
	}

	public void Set(ulong currentDragonRowId, int i)
	{
	}
}
