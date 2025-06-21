using UnityEngine;
using UnityEngine.InputSystem;

public class RuntimeRebinder : MonoBehaviour
{
    public InputActionReference actionToRebind; // Drag your InputAction (e.g., "Jump")

    private InputActionRebindingExtensions.RebindingOperation rebindOperation;

    public void StartRebinding()
    {
        Debug.Log("BUTTON");
        // Disable the action while rebinding
        actionToRebind.action.Disable();

        rebindOperation = actionToRebind.action
            .PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse") // Optional: to avoid accidental mouse clicks
            .OnMatchWaitForAnother(0.1f)    // Wait a bit for confirmation
            .OnComplete(operation =>
            {
                Debug.Log("New Binding: " + actionToRebind.action.bindings[0].effectivePath);

                operation.Dispose();
                actionToRebind.action.Enable();
            })
            .Start();
    }

    public void CancelRebinding()
    {
        rebindOperation?.Cancel();
        rebindOperation?.Dispose();
        actionToRebind.action.Enable();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            Debug.Log("PLEASE FUCKING WORK");
            StartRebinding();
        }
    }
}
