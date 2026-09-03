public class SettingDebugMediator : MediatorBase
{
	public new const string NAME = "SettingDebugMediator";

	public static float DoubleClick => 0f;

	public static int AbsorbDelay => 0;

	public static int JoyScaleBG => 0;

	public static int JoyScaleTouch => 0;

	public static int JoyRadius => 0;

	public SettingDebugMediator()
		: base(null)
	{
	}
}
