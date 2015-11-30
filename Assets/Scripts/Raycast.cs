using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

    public float interactionDistance = 1f;
    //public bool lookingAtEnemy = false;
    public GameObject playerDude;

    public arrays something;

    private bool audioLive = false;
    private bool audioscan = false;
    //public Material newcolor;

    AudioSource wantToLive;
    AudioSource scanner;


	// Use this for initialization
	void Start ()
    {
        AudioSource[] audios = playerDude.GetComponents<AudioSource>();
        wantToLive = audios[0];
        scanner = audios[1];
    }
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;
        Ray landingRay = new Ray(transform.position, Camera.main.transform.forward);
        Debug.DrawRay(transform.position, Camera.main.transform.forward * interactionDistance);

        if (Physics.Raycast(landingRay, out hit, interactionDistance))
        {
            audioscan = false;
            if (hit.collider.tag == "Enemy")
                {
                scannerTarget();

                //something = gameObject.GetComponent<arrays>();
                    something.identifyEnemy();
                    if (!audioLive)
                    {
                        wantToLive.Play();
                        audioLive = true;
                        //audioscan = true;
                    }

                    print("catfood");
                }

                if (hit.collider.tag == "NPC")
                {
                    scannerTarget();
                    //something = gameObject.GetComponent<arrays>();

                    //something.renderer.GetComponent<Renderer>().material;

                    //something.npcArray.GetValue;
                    audioscan = true;
                    print("non enemy");
                }
            }   
        

    }

    public void scannerTarget()
    {
        if (!audioscan)
        {
            for (int i = 0; i <= 10; i++)
            {
                scanner.Play();
            }
            audioscan = true;
        }
    }
}
