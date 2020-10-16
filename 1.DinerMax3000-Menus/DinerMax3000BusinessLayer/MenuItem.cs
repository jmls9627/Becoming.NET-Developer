﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000.Business
{
    public class MenuItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price
        {
            get{
                /* CDyne.WeatherSoapClient client = new  CDyne.WeatherSoapClient();
                   var resultWeather= Client.GetCityWeatherByZIP("90102");
                   if(int.Parse(resultWather.temperature)>80){
                     return _price * 2; 
                  }
                 */

                return _price; }
            set
            {
                if (value > 0)
                {
                  _price = value;
                }
                else
                {
                    throw new ApplicationException("you can not have free or negative valued items.");
                }

            }
        }



        private double _price;
    }
}
