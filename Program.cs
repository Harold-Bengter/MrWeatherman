using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
//My API key for testing Weathermap: a9bad6a6e7e2bafdfc55e28839f438a
// Create an instance of the HttpClient Class called clientc


var client = new HttpClient();


Console.Write("Welcome to Mr.Weatherman! Please enter your API key: ");
var api_key = Console.ReadLine();


Console.WriteLine("Please enter your current city to see the local temperature: ");
var city_name = Console.ReadLine();


var userURL = $"https://api.openweathermap.org/data/2.5/weather?q={city_name}&appid=c43d574b3e4d08bbd37fe5f80ffeb393&units=imperial";
var myRequest = client.GetStringAsync(userURL).Result;


var response = client.GetStringAsync(userURL).Result;
var weatherResult = JObject.Parse(response).GetValue("main").ToString();

Console.WriteLine($"Thank you for using MR.Weatherman. Your current weather is {weatherResult}. Enjoy that weather!");

