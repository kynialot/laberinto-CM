using UnityEngine;

public class ParedRotadora : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 10f;
    void Update()
    {
        transform.Rotate(0.0f, rotacionY * Time.deltaTime, 0f);
    }
}
