namespace TableTool
{
	public class Achieve_PaymentTaskModel : LocalModel<Achieve_PaymentTask, int>
	{
		private const string _Filename = "Achieve_PaymentTask";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_PaymentTask bean)
		{
			return 0;
		}
	}
}
