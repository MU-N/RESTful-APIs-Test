using TMPro;
using System;
using UnityEngine;

public class JokeHandeler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    
    private void Start()
    {
        GetJoke();
    }

    public void GetJoke()
    {
        Joke j = APIHelper.GetNewJoke();
        textMeshProUGUI.text = j.value;
    }
}
