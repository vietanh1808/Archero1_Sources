using TableTool;
using UnityEngine;

public class MonsterOne : MonoBehaviour
{
	public GameObject modelParent;

	private BodyMask mask;

	[HideInInspector]
	public int monsterid;

	private float limitw;

	private float limith;

	private float defaultSpeed;

	private float turnChcekTime;

	private float turnCount;

	private Equip_Monster emData;

	private int[] arrayL;

	private int[] arrayR;

	private int[] arrayD;

	private int[] arrayU;

	public void LoadMonster(int mid, float limitw, float limith, int quality = 1)
	{
	}

	public void PlayAnimation()
	{
	}

	public void Update()
	{
	}

	private void move()
	{
	}

	private void turn()
	{
	}

	private bool checkBounds()
	{
		return false;
	}

	private void turnBegin()
	{
	}
}
