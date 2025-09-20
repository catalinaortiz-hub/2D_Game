using UnityEngine;

public class GameControllerScene2 : MonoBehaviour
{
    public Timer tiempoEscena;

    public void GuardarTiempoEscena()
    {
        tiempoEscena.TimerStop();
        float tiempoFinal = tiempoEscena.GetStopTime();
        GameManager.Instance.SumaTimeGlobal(tiempoFinal);

        Debug.Log("Tiempo de Escena 2: " + tiempoFinal);
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
