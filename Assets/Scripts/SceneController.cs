using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject _guideScreen;
    public void StartGame()
    {
        SoundManager.instance.Play("Click");
        SceneManager.LoadScene("2048");
    }
    public void OpenGuide()
    {
        SoundManager.instance.Play("Click");
        _guideScreen.SetActive(true);
    }
    public void CloseGuide()
    {
        SoundManager.instance.Play("Click");
        _guideScreen.SetActive(false);
    }
}
