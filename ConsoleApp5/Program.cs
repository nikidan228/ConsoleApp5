using System.Diagnostics;

class TemperatureIncreaser
{
	public void IncreaseTemperature()
	{
		int temperature = -30;
		while (temperature <= 40)
		{
			Console.WriteLine($"Temperature is {temperature}");
			temperature++;
			Thread.Sleep(500); // добавляем задержку, чтобы можно было увидеть изменение температуры
		}
	}
}

class TemperatureTracker
{
	public void TrackTemperature()
	{
		int temperature;
		while (true)
		{
			temperature = GetTemperature();
			if (temperature == -25 || temperature == 0 || temperature == 25 || temperature == 35)
			{
				Console.WriteLine($"Temperature is {temperature}");
			}
			Thread.Sleep(1000); // добавляем задержку, чтобы не было слишком много сообщений
		}
	}
	private int GetTemperature()
	{
		// здесь можно написать код получения температуры из какого-то источника (например, датчика)
		// для примера просто генерируем случайное число
		Random rnd = new Random();
		return rnd.Next(-30, 41);
	}
}

class incr
{
	static void Main(string[] args)
	{
		TemperatureIncreaser incr = new TemperatureIncreaser();
		TemperatureTracker tracker = new TemperatureTracker();
		int GetTemperature()
		{
			throw new NotImplementedException();
		}
	}
	// запускаем два потока, один для увеличения температуры, другой для отслеживания
	Thread t1 = new Thread(new ThreadStart(incr.IncreaseTemperature));
	Thread t2 = new Thread(new ThreadStart(tracker.TrackTemperature));
}

