using Demo.Web.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web.Pages
{
    public class FetchDataBase : ComponentBase 
    {
       private WeatherForecast[] forecasts;
       private readonly WeatherForecastService _weatherForecastService = new WeatherForecastService();

        protected override async Task OnInitializedAsync()
        {
            forecasts = await _weatherForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
