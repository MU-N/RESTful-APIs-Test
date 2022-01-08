using System.Net;
using System.IO;
using UnityEngine;

public static class APIHelper 
{
   public static Joke GetNewJoke()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.chucknorris.io/jokes/random");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jason = reader.ReadToEnd();
        return JsonUtility.FromJson<Joke>(jason);
    }
}
