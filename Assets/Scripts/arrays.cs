using UnityEngine;
using System.Collections;

public class arrays : MonoBehaviour
{
    public GameObject npc00;
    public GameObject npc01;
    public GameObject npc02;
    public GameObject npc03;
    public GameObject npc04;
    public GameObject npc05;
    public GameObject npc06;
    public GameObject npc07;
    public GameObject npc08;
    public GameObject npc09;
    

    public GameObject[] npcArray;

    public Material target;
    public Material nonTarget;

    public int enemyTagged;
    public int nonEnemyTagged;

    void Awake()
    {
        npcArray = new GameObject[] { npc00, npc01, npc02, npc03, npc04, npc05, npc06, npc07, npc08, npc09 };
        enemyTagged = Random.Range(0, 9);
        createRandomEnemy();
    }

    // Use this for initialization
    void Start ()
    {
        //createRandomEnemy();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void createRandomEnemy()
    {

        npcArray[enemyTagged].gameObject.tag = "Enemy";

    }

    public void identifyEnemy()
    {
        npcArray[enemyTagged].GetComponent<Renderer>().material = target;
        print(target); 
       
    }

 /*   public void identifyNonEnemy()
    {
        npcArray[nonEnemyTagged].GetComponent<Renderer>().material = nonTarget;
    }*/

    public int randomIntExcept(int min, int max, int except)
    {
        int result = Random.Range(min, max - 1);
        if (result >= except) result += 1;
        return result;
    }

}
