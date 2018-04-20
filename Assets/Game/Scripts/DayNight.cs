using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour {
    public Color display;
    public Color day;
    public Color night;
    public float rotSpeed;
    public float daySpeed;

    public GameObject background;
    //public GameObject background2;
    SpriteRenderer back;

    // Use this for initialization
    void Start() {

        back = background.GetComponent<SpriteRenderer>();
        Debug.Log(display + "display");
        Debug.Log(night + "night");
        Debug.Log(day + "day");
   }

    // Update is called once per frame
    void Update() {
        transform.Rotate(new Vector3(0, 0, rotSpeed));
        background.GetComponent<SpriteRenderer>().material.color =Color.Lerp(day, night, Mathf.PingPong(gameObject.transform.rotation.z, daySpeed));
        //background2.GetComponent<SpriteRenderer>().material.color = Color.Lerp(day, night, Mathf.PingPong(gameObject.transform.rotation.z, daySpeed));

        //Mathf.Lerp(display.g, night.g, colorSpeed);
        //Mathf.Le.p(display.b, night.b, colorSpeed);
        //Mathf.Lerp(display.a, night.a, colorSpeed);


    }
}
