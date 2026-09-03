using System.Collections.Generic;
using UnityEngine;

public class EggHatchCtrl : MonoBehaviour
{
	public class EggIconData
	{
		public int eggid;

		public int count;
	}

	public EggPlate[] plates;

	public DxxText Text_Title;

	public DxxText Text_SubTitle;

	public DxxText Text_Info;

	public GameObject scrollContent;

	public GameObject cpIcon;

	public GameObject cpEgg;

	public void init()
	{
	}

	public void OnClose()
	{
	}

	public void handleNotification(string key, object value)
	{
	}

	private void freshEggIcon(int eggid)
	{
	}

	public void sortEggs(List<EggIconData> list)
	{
	}
}
