using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QueueSystemSingle : MonoBehaviour
{
    // Start is called before the first frame update
public GameObject Deck_1;
public GameObject Deck_2;
public GameObject Deck_3;
public GameObject Deck_4;
public GameObject Player_Slot1;
public GameObject Player_Slot2;
public GameObject Player_Slot3;
public GameObject Player_Slot4;
public string gameWinner;
public int TestTag;
public List<GameObject> PlayerTable = new List<GameObject>();
void Start() { 
    PlayerTable.Add(Deck_1);
    PlayerTable.Add(Deck_2);
    PlayerTable.Add(Deck_3);
    PlayerTable.Add(Deck_4);
          
Debug.Log(PlayerTable[0] + " " + PlayerTable[1] + " " + PlayerTable[2] + " " + PlayerTable[3]);

    //while (gameWinner != null){
      while (TestTag < 7) {  
        for (int i=0;i<3;i++){
            for (int j=0; j<7;j++){
        PlayerTable[i].transform.GetChild(j).GetComponent<BoxCollider>().enabled = true;
        }
        PlayerTable[i].GetComponent<DeckCardsTransform>().enabled = true;        
        StartCoroutine(WaitForInput());
        
            for (int j=0; j<7;j++){
        PlayerTable[i].transform.GetChild(j).GetComponent<BoxCollider>().enabled = false;
        }
        PlayerTable[i].GetComponent<DeckCardsTransform>().enabled = false;
        TestTag++;      
        }
    }
}
void Update() {
}

    IEnumerator WaitForInput()
    {
        //Print the time of when the function is first called.
        //Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(10);

        //After we have waited 5 seconds print the time again.
        //Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}

//trzeba to zrobić async i await