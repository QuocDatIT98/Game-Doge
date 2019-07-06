using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfController : MonoBehaviour {

    // Use this for initialization
    public GameObject Boom;
    public float minBoomTime = 2;
    public float maxBoomTime = 4;
    private float boomTime = 0;
    private float lastBoomTime = 0;
    private GameObject sheep;
    private Animator anim;
    public float throughBoomTime = 0.2f;
    private GameObject gameController;
	void Start () {

        upDateBoomTime();
        sheep = GameObject.FindGameObjectWithTag("Player");
        anim = gameObject.GetComponent<Animator>();
        anim.SetTrigger("notBoom");
        gameController = GameObject.FindGameObjectWithTag("GameController");
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= lastBoomTime + boomTime-throughBoomTime)
        {
            anim.SetTrigger("boom");
            anim.SetTrigger("notBoom");

        }
        if (Time.time >= lastBoomTime + boomTime)
        {
            TroughBoom();
           

        }
    }
    void upDateBoomTime()
    {
        lastBoomTime = Time.time;
        boomTime = Random.Range(minBoomTime, maxBoomTime + 1);
    }

	
    void TroughBoom()
    {
        
        GameObject Bom = Instantiate(Boom, transform.position, Quaternion.identity) as GameObject;

        Bom.GetComponent<boomController>().target = sheep.transform.position;

        upDateBoomTime();
        gameController.GetComponent<GameController>().GetPoint();
       
    }
}
