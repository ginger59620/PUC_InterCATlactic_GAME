using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Note : MonoBehaviour
{
    double timeInstantiated;
    public float assingedTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeInstantiated = SongManager.GetAudioSourceTime();
    }

    // Update is called once per frame
    void Update()
    {
        double timeSinceInstantied = SongManager.GetAudioSourceTime() - timeInstantiated;
        float t = (float)(timeInstantiated / (SongManager.Instance.noteTime * 2));

        if (t > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(Vector3.up * SongManager.Instance.noteSpawnY, Vector3.up * SongManager.Instance.noteDespawnY, t);
        }

            
    }
}
