namespace TestMultipleOIDC.Services.Caching
{
    public interface IWeatherCache
    {
        ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
    }
}
