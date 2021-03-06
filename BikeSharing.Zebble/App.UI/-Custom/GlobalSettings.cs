﻿using System;

namespace UI
{
    public static class GlobalSettings
    {
        public const string AuthenticationEndpoint = "http://192.168.1.3:83/";// "http://bikesharing-services-profilestgr242k3hirba.azurewebsites.net/";
        public const string EventsEndpoint = "http://192.168.1.3:81/";// "http://bikesharing-services-eventstgr242k3hirba.azurewebsites.net/";
        public const string IssuesEndpoint = "http://192.168.1.3:82/";// "http://bikesharing-services-feedbacktgr242k3hirba.azurewebsites.net/";
        public const string RidesEndpoint = "http://192.168.1.3:8000/";//"http://bikesharing-services-ridestgr242k3hirba.azurewebsites.net/";
        public const string OpenWeatherMapEndpoint = "http://api.openweathermap.org/";
        public const string OpenWeatherMapAPIKey = "a62cddcaa47bd94ae33f6390d647d009";

        public const string HockeyAppAPIKeyForAndroid = "a62cddcaa47bd94ae33f6390d647d009";
        public const string HockeyAppAPIKeyForiOS = "a62cddcaa47bd94ae33f6390d647d009";

        public const string SkypeBotAccount = "skype:YOUR_BOT_ID?chat";

        public const string BingMapsAPIKey = " IFeH2NOugVm5OjmsTnDK~qq6_A--_sHbo8GiG6ZnHMQ~AuVhYBYCv1I2A4NMbZhbmM0YRk4cVet8XJfjv3Ok5eGwSX53A-R1G4wxiJLs_Hvp";


        public static string City => "Redmond";
        public static float Temp = 56;
        public static int TenantId = 1;

        public static DateTime EventDate = new DateTime(2017, 03, 07);
        public static float EventLatitude = 47.673988f;
        public static float EventLongitude = -122.121513f;
    }
}