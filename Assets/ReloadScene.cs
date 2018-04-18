using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadScene : MonoBehaviour
{
    public int timer;
    public Text timerText;
    
    IEnumerator Start()
    {
        for (int i = timer; i > 0; i--)
        {
            timerText.text = "Time Left: " + i;
            yield return new WaitForSeconds(1);
        }

        LoadMenu();
    }

    public void LoadMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
