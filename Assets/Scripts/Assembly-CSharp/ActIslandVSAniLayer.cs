using UnityEngine;

public class ActIslandVSAniLayer : MonoBehaviour
{
	public ActIslandVSPlay playUI;

	public RectTransform startPos;

	public RectTransform middleLeftPos;

	public RectTransform middleRightPos;

	public RectTransform endPos;

	public GameObject[] fireItems;

	public GameObject[] bombItems;

	public DxxText[] attackItems;

	private int fontNormal;

	private int fontSuper;

	public void init()
	{
	}

	public void flyFireBomb(int index, int damage, bool red)
	{
	}

	public void flyFireBombFive(int total, int damage, bool red)
	{
	}
}
