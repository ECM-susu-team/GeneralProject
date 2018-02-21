using UnityEngine;

public class Bars : MonoBehaviour {

    public float curHP = 100;
    public GameObject barHP;
	
	void Start () {
		
	}

	void Update () {
        barHP.transform.localScale = new Vector3(curHP / 100, 1, 1);
    }
}
