using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class HeroAssistLine : MonoBehaviour
{
	public Image Image_Left;

	public DxxText Text_LeftLevel;

	public Image[] Image_Right;

	public DxxText[] Text_RightLevel;

	public GameObject[] Locker;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(int heroid, List<int> heros, int mlevel, List<int> levels)
	{
	}
}
