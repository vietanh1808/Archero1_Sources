using UnityEngine;
using UnityEngine.UI;

public class DiglogueItem : MonoBehaviour
{
	public Image leftImage;

	public Image rightImage;

	public TypewriterEffect TypeWriter;

	public GameObject leftName;

	public GameObject rightName;

	public GameObject arrow;

	public DxxText leftNameTex;

	public DxxText rightNameTex;

	[HideInInspector]
	public bool isEnd;

	private void Awake()
	{
	}

	public void Open(int position, int name, string content, string picName)
	{
	}

	public void End()
	{
	}

	public void OnUpdate()
	{
	}
}
