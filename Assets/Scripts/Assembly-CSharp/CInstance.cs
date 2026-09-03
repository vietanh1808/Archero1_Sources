using XLua;

public class CInstance<T> : ISingleton where T : new()
{
	private static T _instance;

	private static DelegateBridge __Hotfix0_get_Instance;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_LateInit;

	private static DelegateBridge __Hotfix0_ReLogin;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnLateInit;

	private static DelegateBridge __Hotfix0_OnReLogin;

	private static DelegateBridge __Hotfix0_OnClear;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static T Instance => default;

	protected virtual void Init()
	{
	}

	protected virtual void LateInit()
	{
	}

	protected virtual void ReLogin()
	{
	}

	protected virtual void Clear()
	{
	}

	public void OnInit()
	{
	}

	public void OnLateInit()
	{
	}

	public void OnReLogin()
	{
	}

	public void OnClear()
	{
	}
}
