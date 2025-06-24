using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class TutoriaWindow : MonoBehaviour
{
    [SerializeField] private VideoPlayer cutsceneWindow;
   [SerializeField] private VideoPlayer tutorialWindow;

    void Start()
    {
        if (cutsceneWindow != null && tutorialWindow != null)
        {
            tutorialWindow.gameObject.SetActive(false);
            cutsceneWindow.loopPointReached += OnFirstVideoFinished;
            cutsceneWindow.Play();
        }
    }
    void OnFirstVideoFinished(VideoPlayer vp)
    {
        cutsceneWindow.gameObject.SetActive(false);

       tutorialWindow.gameObject.SetActive(true);
       tutorialWindow.Play();
    }
}
