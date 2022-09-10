using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    public UnityEvent buttonClick;

    private void Awake()
    {
        if (buttonClick == null)
        {
            buttonClick = new UnityEvent();
        }
    }
    private void OnMouseUp()
    {
        Debug.Log("Game Reset");
        buttonClick.Invoke();
    }
}
