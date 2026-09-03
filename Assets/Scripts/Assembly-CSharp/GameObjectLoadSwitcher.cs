using UnityEngine;

public class GameObjectLoadSwitcher : MonoBehaviour
{
	[SerializeField]
	private string currentName;

	[SerializeField]
	private LoadSwitchGroup[] groups;

	private SwitchObj[] gos;

	private void Awake()
	{
	}

	public void Set(string name)
	{
	}
}
