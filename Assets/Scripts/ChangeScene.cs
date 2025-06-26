using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
 
    public void TitleScrene()
    {
        SceneManager.LoadScene("TitleScrene");
    }
    public void ModeSelect()
    {
        SceneManager.LoadScene("ModeSelect");
    }
    public void Options()
    {

        SceneManager.LoadScene("Options");
    }

    public void FreeMode()
    {

        SceneManager.LoadScene("FreeMode");
    }

    public void NeptuneLevel()
    {

        SceneManager.LoadScene("NeptuneLevel");
    }
    public void TutorialLevel()
    {

        SceneManager.LoadScene("TutorialLevel");
    }
    public void MusicSelect()
    {

        SceneManager.LoadScene("MusicSelect");
    }
    public void LevelSelect()
    {

        SceneManager.LoadScene("LevelSelect");
    }
    public void Cutscene()
    {
        SceneManager.LoadScene("Cutscene");
    }
    public void VisualNovel1()
    {
        SceneManager.LoadScene("VisualNovel1");
    }
    public void VisualNovel2()
    {
        SceneManager.LoadScene("VisualNovel2");
    }
    public void VisualNovel3()
    {
        SceneManager.LoadScene("VisualNovel3");
    }
}
