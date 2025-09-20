using UnityEngine;

public class GameControllerScene1 : MonoBehaviour
{
    public Timer tiempoEscena;

    public void GuardarTiempoEscena()
    {

        // Accedemos al stopTime
        float tiempoFinal = tiempoEscena.GetStopTime();

        // Lo mandamos al GameManager
        GameManager.Instance.SumaTimeGlobal(tiempoFinal);

        Debug.Log("Tiempo de esta escena: " + tiempoFinal);
        //Debug.Log("Tiempo global acumulado: " + GameManager.Instance.Globaltime1);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
