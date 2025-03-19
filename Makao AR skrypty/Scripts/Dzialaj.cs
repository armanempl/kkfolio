using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Dzialaj : MonoBehaviour
{
    public GameObject karta;
    public GameObject a;
    public GameObject rodzic;
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject Slot5;
    public GameObject Slot6;
    public GameObject Slot7;
    public GameObject Deck;
    public GameObject Deck2;
    public GameObject Deck3;
    public GameObject Deck4;
    public GameObject slot;
    public GameObject Panel1;
    string nazwa = "2_Kier";
    public int licznik = 28;
    public int liczba;
    public List<string> randomCards2;

    public void dodaj()
    {
        string[] cards =  {"2_Pik","2_Kier","2_Trefl","2_Karo","3_Pik","3_Kier","3_Trefl","3_Karo","4_Pik","4_Kier","4_Trefl","4_Karo","5_Pik","5_Kier","5_Trefl","5_Karo","6_Pik","6_Kier","6_Trefl","6_Karo",
       "7_Pik","7_Kier","7_Trefl","7_Karo","8_Pik","8_Kier","8_Trefl","8_Karo","9_Pik","9_Kier","9_Trefl","9_Karo","10_Pik","10_Kier","10_Trefl","10_Karo","Walet_Pik","Walet_Kier","Walet_Trefl","Walet_Karo",
       "Dama_Kier","Dama_Trefl","Dama_Karo","Dama_Pik","Krol_Pik","Krol_Kier","Krol_Karo","Krol_Trefl","As_Kier","As_Trefl","As_Pik","As_Karo", "Joker_1", "Joker_2"};


        List<string> randomCards = new List<string>();
        for (int i = 0; i < cards.Length; i++)
        {
            if (!randomCards.Contains(cards[i]))
            {
                randomCards.Add(cards[i]);
            }
        }
        //List<string> randomCards2 = new List<string>();

        for (int i = 0; i < 54; i++)
        {
            int randomIndex = UnityEngine.Random.Range(0, randomCards.Count);
            randomCards2.Add(randomCards[randomIndex]);
            randomCards.RemoveAt(randomIndex);
        }

        for (int i = 0; i<54; i++)
        {
            Debug.Log("***********************************" +i+" "+ randomCards2[i]);
        }
        

        for(int j = 0; j<4; j++)
        {
            if (j == 0)
            {
                for (int i = 0; i < 7; i++)
                {
                    Transform slot = Deck.transform.GetChild(i);
                    Debug.Log(slot);
                    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[i]);
                    karta.transform.SetParent(slot.transform);
                    karta.transform.localPosition = new Vector3(0, 0, 0);
                    karta.transform.localScale = new Vector3(28, 28, 1);
                }
            }
            if (j == 1)
            {
                for (int i = 0; i < 7; i++)
                {
                    Transform slot = Deck2.transform.GetChild(i);
                    Debug.Log(slot);
                    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[i+7]);
                    karta.transform.SetParent(slot.transform);
                    karta.transform.localPosition = new Vector3(0, 0, 0);
                    karta.transform.localRotation = Quaternion.Euler(0, 0, 180);
                    karta.transform.localScale = new Vector3(28, 28, 1);
                }
            }
            if (j == 2)
            {
                for (int i = 0; i < 7; i++)
                {
                    Transform slot = Deck3.transform.GetChild(i);
                    Debug.Log(slot);
                    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[i+14]);
                    karta.transform.SetParent(slot.transform);
                    karta.transform.localPosition = new Vector3(0, 0, 0);
                    karta.transform.localRotation = Quaternion.Euler(0, 0, 180);
                    karta.transform.localScale = new Vector3(28, 28, 1);
                }
            }
            if (j == 3)
            {
                for (int i = 0; i < 7; i++)
                {
                    Transform slot = Deck4.transform.GetChild(i);
                    Debug.Log(slot);
                    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[i+21]);
                    karta.transform.SetParent(slot.transform);
                    karta.transform.localPosition = new Vector3(0, 0, 0);
                    karta.transform.localRotation = Quaternion.Euler(0, 0, 180);
                    karta.transform.localScale = new Vector3(28, 28, 1);
                }
            }
        }
        //for (int i = 0; i < 7; i++)
        //{
        //    Transform slot = Deck.transform.GetChild(i);
        //    Debug.Log(slot);
        //    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[i]);
        //    karta.transform.SetParent(slot.transform);
        //    karta.transform.localPosition = new Vector3(0, 0, 0);
        //}


        //if (i == 1) {
        //    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[i]);
        //    karta.transform.SetParent(Slot1.transform);
        //    karta.transform.localPosition = new Vector3(0, 0, 0);
        //}
        //if (i == 2) {
        //    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[i]);
        //    karta.transform.SetParent(Slot2.transform);
        //    karta.transform.localPosition = new Vector3(0, 0, 0);
        //}
        //if (i == 3) {
        //    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[i]);
        //    karta.transform.SetParent(Slot3.transform);
        //    karta.transform.localPosition = new Vector3(0, 0, 0);
        //}
        //if (i == 4) {
        //    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[i]);
        //    karta.transform.SetParent(Slot4.transform);
        //    karta.transform.localPosition = new Vector3(0, 0, 0);
        //}
        //if (i == 5) {
        //    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[i]);
        //    karta.transform.SetParent(Slot5.transform);
        //    karta.transform.localPosition = new Vector3(0, 0, 0);
        //}
        //if (i == 6) {
        //    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[i]);
        //    karta.transform.SetParent(Slot6.transform);
        //    karta.transform.localPosition = new Vector3(0, 0, 0);
        //}
        //if (i == 7) {
        //    karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[i]);
        //    karta.transform.SetParent(Slot7.transform);
        //    karta.transform.localPosition = new Vector3(0, 0, 0);
        //}

        //karta.transform.localPosition = new Vector3(-0.52f, -1.49f, -2.803f);
        //karta.transform.localPosition += Vector3.right * 0.06f * i;
        //karta.transform.localPosition += Vector3.forward * -0.001f * i;
        //Debug.Log(karta.name);

        
    }
    public void Dobierz()
    {
        int ilosc_slotow = Panel1.transform.childCount;
        for (int i = 0; i < ilosc_slotow; i++)
        {
            Transform slot = Panel1.transform.GetChild(i);
            if (slot.transform.childCount == 0)
            {
                karta = GameObject.Find("/GameObject/CardStash/" + randomCards2[licznik]);
                karta.transform.SetParent(slot.transform);
                karta.transform.localPosition = new Vector3(0, 0, 0);
                karta.transform.localScale = new Vector3(33, 33, 1);
                
                break;
            }
        }
        Panel1.gameObject.SetActive(false);
        licznik++;
        Debug.Log("++++++++++++++++++++++++++++++++++++++++++" + licznik);
    }

}
