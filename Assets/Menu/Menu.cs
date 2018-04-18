using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public Image loadbar;
    private bool startload;
    public float loadSpeed;
    float speed;
    private void Update()
    {
        if (!loadbar) return;
        speed += loadSpeed * Time.deltaTime;
        if (startload == false)
        {
            loadbar.fillAmount = Mathf.Lerp(loadbar.fillAmount, 0, speed);
        }
        else
        {
            loadbar.fillAmount = Mathf.Lerp(loadbar.fillAmount, 1, speed);
        }
    }
    public void LoadScene(string sceneload)
    {
        SceneManager.LoadScene(sceneload);
    }
	
    public void StartLoading(bool loading)
    {
        startload = loading;
    }
	
}
