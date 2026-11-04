using UnityEngine;

public class colisones : MonoBehaviour
{

[SerializeField]
    Material ParedPorDefecto;

    [SerializeField]
    Material ParedTocada;

    bool paredRoja = false;

    float tiempoEnRojo = 2f;

    private void Update()
    {
        if (paredRoja == true)
        {
            tiempoEnRojo = tiempoEnRojo - Time.deltaTime;

            if (tiempoEnRojo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = ParedPorDefecto;
                paredRoja = false;
                tiempoEnRojo = 2f;
            }
        }
    }

    //Funcion que se ejecuta al chocar un objeto con este GameObject.
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = ParedTocada;
            paredRoja = true;
        }
    }



}