using Unity.VisualScripting;
using UnityEngine;

public class Respawm : MonoBehaviour
{
    public GameObject puntito;
     void OnTriggerEnter(Collider other)
    {
        other.transform.position = puntito.transform.position;
    }
}
    