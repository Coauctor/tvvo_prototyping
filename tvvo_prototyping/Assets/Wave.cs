using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public GameObject Player2;
    public GameObject WaveObject;

	void Start () {
		
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(WaveObject);
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
