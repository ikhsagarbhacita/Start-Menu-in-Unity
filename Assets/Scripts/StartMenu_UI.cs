using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu_UI : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }

    public void Play(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }       

    public void Mailto(string email)
    {
        Application.OpenURL("mailto:" + email);
    }

    public void BGMVolume(float volume)
    {
        PlayerPrefs.SetFloat("Volume", volume);
    }
}
