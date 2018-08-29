using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public float WaveSpeed;

    public Transform Player1;
    public Transform Player2;
    public GameObject WaveObject;

    private bool waveExist = false;
	
	void Update ()
    {
        LaunchWave();
    }

    void LaunchWave()
    {
        if (Input.GetKeyDown(KeyCode.Space) & waveExist = false)
        {
            float speed = WaveSpeed * Time.deltaTime;
            Instantiate(WaveObject, transform.position + (transform.right * 2), transform.rotation);
            WaveObject.transform.position = Vector3.MoveTowards(Player1.position, Player2.position, speed);
            Debug.Log("Wave!");
            bool waveExist = true;
        }
    }
    //1. если игрок нажал на пробел
    // - заспавнить объект волна
    // - волна движется к координатам игрока 2

    //3. когда волна дошла до игрока 2, она возвращается к игроку 1
    //4. если волна в радиусе Т и игрок 1 не нажал пробел, то уничтожить волну
    //5. в противном случае — повторить с шага 2
}
