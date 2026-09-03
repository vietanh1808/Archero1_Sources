namespace Activity.Anniversary.Exchange.Data
{
	public class ExchangeData
	{
		private ExchangeConfigData ExchangeConfigData { get; set; }

		public bool IsOpen => false;

		public bool IsOpenTime => false;

		public bool IsPreOpen => false;

		public long ActivityLeftTime => 0L;

		public long ActivityPreOpenLeftTime => 0L;

		public int HaveCurrencyCount => 0;

		public bool HaveData => false;

		public void SyncRemoteData(ExchangeConfigData exchangeConfigData)
		{
		}

		public void Clear()
		{
		}

		public void UpdateCurrency(int count)
		{
		}
	}
}
