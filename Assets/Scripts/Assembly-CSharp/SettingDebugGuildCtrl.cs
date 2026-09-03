using UnityEngine;
using UnityEngine.UI;

public class SettingDebugGuildCtrl : MonoBehaviour
{
	public ButtonCtrl unTestServer;

	public ButtonCtrl quasiServer;

	public ButtonCtrl testServer;

	public ButtonCtrl showLog;

	public ButtonCtrl switchTryPlaySkill;

	public Text url;

	public Text imUrl;

	public Text select;

	public const string useFormalKey = "formalGuildServer";

	public const string showDebugLog = "guildShowDebugLog";

	private void Awake()
	{
	}

	private void updateSwitchTryPlaySkillText()
	{
	}

	private void RestUI()
	{
	}
}
