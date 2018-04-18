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

    bool loading;

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

        if (loadbar.fillAmount >= .95f && !loading)
        {
            loading = true;
            LoadScene("Game");
        }
    }
    public void LoadScene(string sceneload)
    {
        SceneManager.LoadSceneAsync(sceneload);
    }
	
    public void StartLoading(bool loading)
    {
        startload = loading;
    }
	
}
