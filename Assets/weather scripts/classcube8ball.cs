using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class classcube8ball : MonoBehaviour
{
    public string place1;
    bool Reset;
    bool ResetZ;
    string[] str1;
    public AudioClip sound;
    public AudioSource audio;
    public GameObject textWeather;

    void Start()
    {

        Reset = true;
        if (place1 == "Madrid")
        {
            str1 = new string[] { "It is Certain", "It is decidedly so", "Without a doubt", "Yes definitely", "You may rely on it", "As I see it, yes.", "Most likely", "Outlook good", "Yes", "Signs point to yes", "Reply hazy, try again", "Ask again later", "Better not tell you now", "Cannot predict now", "Concentrate and ask again", "Don't count on it", "My reply is no", "My sources say no", "Outlook not so good", "Very doubtful" };
        }

        else
        {
            str1 = new string[] { "Go ahead with it", "Stay alert", "Are you sure?", "Maybe you shouldn't", "I would say, YES ", "Seems okay", "NO", "The universe will guide you", "It is the right thing", "STOP right now" };
        }


    }

    
    void Update()
    {
        Debug.Log(transform.rotation.eulerAngles.x);

        if ((transform.rotation.eulerAngles.x > 70 && transform.rotation.eulerAngles.x < 110 && Reset == true))
        {
            audio.PlayOneShot(sound);
            System.Random random = new System.Random();
            int num = random.Next(0, str1.Length);

            textWeather.GetComponent<TextMeshPro>().text = str1[num];
            Reset = false;
        }

        if ((transform.rotation.eulerAngles.z > 70 && transform.rotation.eulerAngles.z < 110 && ResetZ == true))
        {
            audio.PlayOneShot(sound);
            System.Random random = new System.Random();
            int num = random.Next(0, str1.Length);

            textWeather.GetComponent<TextMeshPro>().text = str1[num];
            ResetZ = false;
        }
        if ((transform.rotation.eulerAngles.x < 30 || transform.rotation.eulerAngles.x > 310))
        {
            Reset = true;
        }
        if ((transform.rotation.eulerAngles.z < 30 || transform.rotation.eulerAngles.z > 310))
        {
            ResetZ = true;
        }
    }
}