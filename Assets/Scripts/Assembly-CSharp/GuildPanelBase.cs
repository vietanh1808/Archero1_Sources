using UnityEngine;

public abstract class GuildPanelBase : MonoBehaviour
{
	public virtual void OnInit()
	{
	}

	public virtual void showPanel()
	{
	}

	public virtual void hidePanel()
	{
	}

	public virtual void onExit()
	{
	}

	public abstract void onLanguageChanged();

	public virtual void onNote(string key, object value)
	{
	}
}
