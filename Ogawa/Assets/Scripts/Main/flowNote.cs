using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowNote : MonoBehaviour {

	[SerializeField]
	private GameObject Don;

	[SerializeField]
	private GameObject Ka;

	private float testObjSpeed = 0.5f;
	private const float testTime = 1.0f;	//0.5秒に１回ながれる

	private float nowTime = 0.0f;

	[SerializeField]
	private GameObject lane;



	void Start () {
		
	}


	// Update is called once per frame
	void Update () {

		nowTime += Time.deltaTime;

		if(nowTime < testTime){
			return;
		}

		nowTime = 0.0f;
		int num = Random.Range(0,3);

		switch(num)
		{
			case 0:
				Taiko don = Instantiate(Don).GetComponent<Taiko>();
				don.SetGoalPos(lane);
				break;
			case 1:
				Taiko ka = Instantiate(Ka).GetComponent<Taiko>();
				ka.SetGoalPos(lane);
				break;
			case 2:
				break;
		}
		
	}
}
