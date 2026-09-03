using UnityEngine;

public class UserBackPageBase : MonoBehaviour
{
	public virtual void OnInit()
	{
	}

	public virtual void UpdateUI(bool reset = false)
	{
	}

	public virtual void OnLanguageChange()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	private void SetActive(bool toOpen)
	{
	}
}
