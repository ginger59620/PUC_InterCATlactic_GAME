using UnityEngine;

public class LevelEffects : MonoBehaviour
{
    private Vector2 initialPosition;
    [SerializeField] private Vector2 finalPosition;

    private void Awake()
    {
        initialPosition = transform.position;
    }

  
    private void Update()
    {
        transform.position = Vector2.Lerp(transform.position, finalPosition, 0.1f);
    }

    private void OnDisable()
    {
        transform.position = initialPosition;
    }
}
