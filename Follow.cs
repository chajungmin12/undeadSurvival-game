using UnityEngine;

public class Follow : MonoBehaviour
{
    RectTransform rect;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    // void FixedUpdate()
    //     {
    //     rect.position = Camera.main.WorldToScreenPoint(GameManager.instance.player.transform.position);
    //     }
    // Confused Camera (version problem) 
}
