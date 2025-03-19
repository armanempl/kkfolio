using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = System.Random;



public class RandomCards : MonoBehaviour
{
    public GameObject TextBox;
    public int TheNumber;
    
    class Card
    {
        public Card(int id, int number, string color)
        {
            this.id = id;
            this.number = number;
            this.color = color;
            activ = 0;
        }
        public int id;
        public int number;
        public string color;
        public int activ;

    }

    public void RandomCard () {
        
        Card pik2 = new Card(1, 2, "pik");
        Card pik3 = new Card(2, 3, "pik");
        Card pik4 = new Card(3, 4, "pik");
        Card pik5 = new Card(4, 5, "pik");
        Card pik6 = new Card(5, 6, "pik");
        Card pik7 = new Card(6, 7, "pik");
        Card pik8 = new Card(7, 8, "pik");
        Card pik9 = new Card(8, 9, "pik");
        Card pik10 = new Card(9, 10, "pik");
        Card pikWalet = new Card(10, 11, "pik");
        Card pikDama = new Card(11, 12, "pik");
        Card pikKrol = new Card(12, 13, "pik");
        Card pikAS = new Card(13, 14, "pik");

        Card kier2 = new Card(14,2, "kier");
        Card kier3 = new Card(15,3, "kier");
        Card kier4 = new Card(16,4, "kier");
        Card kier5 = new Card(17,5, "kier");
        Card kier6 = new Card(18,6, "kier");
        Card kier7 = new Card(19,7, "kier");
        Card kier8 = new Card(20,8, "kier");
        Card kier9 = new Card(21,9, "kier");
        Card kier10 = new Card(22,10, "kier");
        Card kierWalet = new Card(23,11, "kier");
        Card kierDama = new Card(24,12, "kier");
        Card kierKrol = new Card(25,13, "kier");
        Card kierAS = new Card(26,14, "kier");

        Card trefl2 = new Card(27,2, "trefl");
        Card trefl3 = new Card(28,3, "trefl");
        Card trefl4 = new Card(29,4, "trefl");
        Card trefl5 = new Card(30,5, "trefl");
        Card trefl6 = new Card(31,6, "trefl");
        Card trefl7 = new Card(32,7, "trefl");
        Card trefl8 = new Card(33,8, "trefl");
        Card trefl9 = new Card(34,9, "trefl");
        Card trefl10 = new Card(35,10, "trefl");
        Card treflWalet = new Card(36,11, "trefl");
        Card treflDama = new Card(37,12, "trefl");
        Card treflKrol = new Card(38,13, "trefl");
        Card treflAS = new Card(39,14, "trefl");

        Card karo2 = new Card(40,2, "karo");
        Card karo3 = new Card(41,3, "karo");
        Card karo4 = new Card(42,4, "karo");
        Card karo5 = new Card(43,5, "karo");
        Card karo6 = new Card(44,6, "karo");
        Card karo7 = new Card(45,7, "karo");
        Card karo8 = new Card(46,8, "karo");
        Card karo9 = new Card(47,9, "karo");
        Card karo10 = new Card(48,10, "karo");
        Card karoWalet = new Card(49,11, "karo");
        Card karoDama = new Card(50,12, "karo");
        Card karoKrol = new Card(51,13, "karo");
        Card karoAS = new Card(52,14, "karo");

        Card jokerPik = new Card(53, 15, "pik");
        Card jokerKier = new Card(54, 16, "kier");

        List<Card> talia = new List<Card>();
        talia.Add(pik2);
        talia.Add(pik3);
        talia.Add(pik4);
        talia.Add(pik5);
        talia.Add(pik6);
        talia.Add(pik7);
        talia.Add(pik8);
        talia.Add(pik9);
        talia.Add(pik10);
        talia.Add(pikWalet);
        talia.Add(pikDama);
        talia.Add(pikKrol);
        talia.Add(pikAS);

        talia.Add(kier2);
        talia.Add(kier3);
        talia.Add(kier4);
        talia.Add(kier5);
        talia.Add(kier6);
        talia.Add(kier7);
        talia.Add(kier8);
        talia.Add(kier9);
        talia.Add(kier10);
        talia.Add(kierWalet);
        talia.Add(kierDama);
        talia.Add(kierKrol);
        talia.Add(kierAS);

        talia.Add(trefl2);
        talia.Add(trefl3);
        talia.Add(trefl4);
        talia.Add(trefl5);
        talia.Add(trefl6);
        talia.Add(trefl7);
        talia.Add(trefl8);
        talia.Add(trefl9);
        talia.Add(trefl10);
        talia.Add(treflWalet);
        talia.Add(treflDama);
        talia.Add(treflKrol);
        talia.Add(treflAS);

        talia.Add(karo2);
        talia.Add(karo3);
        talia.Add(karo4);
        talia.Add(karo5);
        talia.Add(karo6);
        talia.Add(karo7);
        talia.Add(karo8);
        talia.Add(karo9);
        talia.Add(karo10);
        talia.Add(karoWalet);
        talia.Add(karoDama);
        talia.Add(karoKrol);
        talia.Add(karoAS);

        talia.Add(jokerPik);
        talia.Add(jokerKier);

        string[] cards =  {"2 Pik","2 Kier","2 Trefl","2 Karo","3 Pik","3 Kier","3 Trefl","3 Karo","4 Pik","4 Kier","4 Trefl","4 Karo","5 Pik","5 Kier","5 Trefl","5 Karo","6 Pik","6 Kier","6 Trefl","6 Karo",
       "7 Pik","7 Kier","7 Trefl","7 Karo","8 Pik","8 Kier","8 Trefl","8 Karo","9 Pik","9 Kier","9 Trefl","9 Karo","10 Pik","10 Kier","10 Trefl","10 Karo","Walet Pik","Walet Kier","Walet Trefl","Walet Karo",
       "Dama Kier","Dama Trefl","Dama Karo","Dama Karo","Krol Pik","Krol Kier","Krol Karo","Krol Trefl","As Kier","As Trefl","As Karo","As Karo", "Joker Pik", "Joker Kier"};

        
       //create array for random cards from the array above without duplicates and add them to the list
       List<Card> randomCards = new List<Card>();
       for (int i = 0; i < talia.Count; i++)
       {
           if (!randomCards.Contains(talia[i]))
           {
               randomCards.Add(talia[i]);
           }
       }
        // get 25 random cards from the list without duplicates
        List<Card> randomCards2 = new List<Card>();
        for (int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++){
                int randomIndex = UnityEngine.Random.Range(0, randomCards.Count);
                randomCards2.Add(randomCards[randomIndex]);
                randomCards.RemoveAt(randomIndex);
            }
        }

        // add 25 random cards to the textbox
       // TextBox.GetComponent<Text>().text = "";
        foreach (Card card in randomCards2)
        {
           // TextBox.GetComponent<Text>().text += card + " \n";
            //dispay card in console for testing
            UnityEngine.Debug.Log(card.number + card.color);

        }

        // get the number of the card
        TheNumber = UnityEngine.Random.Range(0, randomCards2.Count);

        
        
    }

    
       
    //List<int> drawnCards = new List<int>();
    // Queue myQ = new Queue();
    //Random rand = new Random();
       
    //    for( int i=1; i<=5; i++)
    //    {

    //         // TextBox.GetComponent<Text>().text += "gracz: " + i + "karty: ";

    //         for(int j=1;j<=5;j++){

    //             //get random string from card cards array
    //             TheNumber = rand.Next(cards.Length);
    //             //create drawnCards array and add card it without repeating
    //             if(drawnCards.Contains(TheNumber)){
    //                TheNumber = rand.Next(cards.Length);
    //             }
    //             else{
    //                drawnCards.Add(TheNumber);
    //             }
               
    //             TextBox.GetComponent<Text>().text += cards[TheNumber] + " ";
                
    //             myQ.Enqueue(cards[TheNumber]);
                
    //         }
                
    //             int index = rand.Next(cards.Length);

    //             // //get random card index from
                
    //             int[] card = new int[]{Convert.ToInt32(index)};
    //             //    //drawnCards.Add(index);
    //             // foreach(var item in card){
    //             //      UnityEngine.Debug.Log(index);
    //             // }
    //         }
            
}