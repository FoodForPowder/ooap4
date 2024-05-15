﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ooap4.Models
{
    [DataContract]
    public class Root
    {
        [DataMember(Name = "now")]
        public long Now { get; set; }
        [DataMember(Name = "now_dt")]
        public string NowDt { get; set; }
        [DataMember(Name = "info")]
        public Info Info { get; set; }
        [DataMember(Name = "fact")]
        public Fact Fact { get; set; }
        [DataMember(Name = "forecast")]
        public Forecast Forecast { get; set; }
    }

    [DataContract(Name = "fact")]
    public class Fact
    {
        [DataMember(Name = "temp")]
        public double Temp { get; set; }
        [DataMember(Name = "feels_like")]
        public double FeelsLike { get; set; }
        [DataMember(Name = "icon")]
        public string Icon { get; set; }
        [DataMember(Name = "condition")]
        public string Condition { get; set; }
        [DataMember(Name = "wind_speed")]
        public double WindSpeed { get; set; }
        [DataMember(Name = "wind_gust")]
        public double WindGust { get; set; }
        [DataMember(Name = "wind_dir")]
        public string WindDir { get; set; }
        [DataMember(Name = "pressure_mm")]
        public double PressureMm { get; set; }
        [DataMember(Name = "pressure_pa")]
        public double PressurePa { get; set; }
        [DataMember(Name = "humidity")]
        public double Humidity { get; set; }
        [DataMember(Name = "daytime")]
        public string Daytime { get; set; }
        [DataMember(Name = "polar")]
        public bool Polar { get; set; }
        [DataMember(Name = "season")]
        public string Season { get; set; }
        [DataMember(Name = "obs_time")]
        public double ObsTime { get; set; }
    }
    [DataContract]
    public class Forecast
    {
        [DataMember(Name = "data")]
        public string Date { get; set; }
        [DataMember(Name = "date_ts")]
        public long DateTs { get; set; }
        [DataMember(Name = "week")]
        public long Week { get; set; }
        [DataMember(Name = "sunrise")]
        public string Sunrise { get; set; }
        [DataMember(Name = "sunset")]
        public string Sunset { get; set; }
        [DataMember(Name = "moon_code")]
        public long MoonCode { get; set; }
        [DataMember(Name = "moon_text")]
        public string MoonText { get; set; }
        [DataMember(Name = "parts")]
        public List<Part> Parts { get; set; }
    }

    [DataContract]
    public class Part
    {
        [DataMember(Name = "part_name")]
        public string PartName { get; set; }
        public long TempMin { get; set; }
        public long TempMax { get; set; }
        public long TempAvg { get; set; }
        public long FeelsLike { get; set; }
        public string Icon { get; set; }
        public string Condition { get; set; }
        public string Daytime { get; set; }
        public bool Polar { get; set; }
        public double WindSpeed { get; set; }
        public long WindGust { get; set; }
        public string WindDir { get; set; }
        public long PressureMm { get; set; }
        public long PressurePa { get; set; }
        public long Humidity { get; set; }
        public long PrecMm { get; set; }
        public long PrecPeriod { get; set; }
        public long PrecProb { get; set; }
    }
    [DataContract]
    public class Info
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Url { get; set; }

        [DataMember(Name = "tzinfo")]
        public Tzinfo tzinfo { get; set; }
    }
    public class Tzinfo
    {
        public int offset { get; set; }
        public string name { get; set; }
        public string abbr { get; set; }
        public bool dst { get; set; }
    }
}