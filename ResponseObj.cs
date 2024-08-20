using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("date")]
    public object date { get; set; }

    [JsonProperty("description")]
    public string description { get; set; }

    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("title_alt")]
    public string titlealt { get; set; }

    [JsonProperty("text")]
    public string text { get; set; }

    [JsonProperty("language")]
    public string language { get; set; }

    [JsonProperty("publisher")]
    public object publisher { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
