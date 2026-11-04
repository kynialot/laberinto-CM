using JetBrains.Annotations;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float velocidad = 0.02f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        // Enteros --> Int
        // Decimales --> Float (f)
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            transform.position += Vector3.right * velocidad;
        }
       {
       if (Input.GetKey(KeyCode.W)) {
                    transform.position += Vector3.forward * velocidad;
          
        } {
       if (Input.GetKey(KeyCode.A)) { 
            transform.position += Vector3.left * velocidad;
          
        } {
       if (Input.GetKey(KeyCode.S)) { 
            transform.position += Vector3.back * velocidad;
          
       if (Input.GetKey(KeyCode.Space))
                        {
                            transform.Translate(0f, .2f, 0f);
                        }
       

        }
       }
           }   
            }
        }
    }