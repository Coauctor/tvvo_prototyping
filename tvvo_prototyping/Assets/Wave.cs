using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public float WaveSpeed;

    public Transform Player2;
    public GameObject WaveObject;
	
	void Update ()
    {
        LaunchWave();
    }

    void LaunchWave()
    {
        float step = WaveSpeed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(WaveObject, transform.position + (transform.right * 2), transform.rotation);
            WaveObject.transform.position = Vector3.MoveTowards(transform.position, Player2.position, step);
            Debug.Log("Wave!");
        }
    }
    //1. если игрок нажал на пробел
    // - заспавнить объект волна
    // - волна движется к координатам игрока 2

    //3. когда волна дошла до игрока 2, она возвращается к игроку 1
    //4. если волна в радиусе Т и игрок 1 не нажал пробел, то уничтожить волну
    //5. в противном случае — повторить с шага 2
}
