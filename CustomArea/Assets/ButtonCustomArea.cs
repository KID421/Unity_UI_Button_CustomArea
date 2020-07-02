using UnityEngine;
using UnityEngine.UI;

public class ButtonCustomArea : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = 0.5f;
    }
}
