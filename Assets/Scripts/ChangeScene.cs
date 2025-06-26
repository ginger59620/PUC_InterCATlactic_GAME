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
    //MENUS
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
    //Gameplay segments
    public void NeptuneLevel()
    {

        SceneManager.LoadScene("NeptuneLevel");
    }
    public void TutorialLevel()
    {

        SceneManager.LoadScene("TutorialLevel");
    }
    public void UranusLevel1()
    {

        SceneManager.LoadScene("UranusLevel1");
    }
    public void UranusLevel2()
    {

        SceneManager.LoadScene("UranusLevel2");
    }
    //Selection menus
    public void MusicSelect()
    {

        SceneManager.LoadScene("MusicSelect");
    }
    public void LevelSelect()
    {

        SceneManager.LoadScene("LevelSelect");
    }
    //Visual Novel Segments
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
