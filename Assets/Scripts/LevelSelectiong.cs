using UnityEngine;
using UnityEngine.UI;

public class LevelSelectiong : MonoBehaviour
{
    [SerializeField] private Button lastButton;
    [SerializeField] private Button nextButton;

    private int currentLevel;
    private int currentSong;

    private void Awake()
    {
        SelectLevel(0);
        SelectMusic(0);
    }

    private void SelectLevel(int _index)
    {
        lastButton.interactable = (_index != 0); //makes the last button dissable
        nextButton.interactable = (_index != transform.childCount-1);

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }

    public void ChangeLevel(int _change)
    {
        currentLevel += _change;
        SelectLevel(currentLevel);
    }

    private void SelectMusic(int _index)
    {
        lastButton.interactable = (_index != 0); //makes the last button dissable
        nextButton.interactable = (_index != transform.childCount - 1);

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }

    public void ChangeMusic(int _change)
    {
        currentSong += _change;
        SelectMusic(currentSong);
    }
}
