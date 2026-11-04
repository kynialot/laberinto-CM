using TMPro;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
  TextMeshProUGUI textLabelTime;

    float tiempoDePartida = 0.0f;
    bool estaJugando = true;
     private void Update()
    {
         if (estaJugando == true)
        {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pantallaFinal.SetActive(true);
            other.GetComponent<Mover>().enabled = false;
            estaJugando = false;
            
        }

    }

}
