using UnityEngine;

public class GameObjectSwitcher : MonoBehaviour
{
	[SerializeField]
	private string currentName;

	[SerializeField]
	private SwitchGroup[] groups;

	private GameObject[] gos;

	private void Awake()
	{
	}

	public void Set(string name)
	{
	}
}
