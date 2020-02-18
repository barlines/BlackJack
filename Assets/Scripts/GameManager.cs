using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;
    public GameObject Card5;
    public GameObject Card6;
    public GameObject Card7;
    public GameObject Card8;
    public GameObject Card9;
    public GameObject Card10;
    public GameObject Card11;
    public GameObject Card12;
    public GameObject Card13;
    public GameObject Card14;
    public GameObject Card15;
    public GameObject Card16;
    public GameObject Card17;
    public GameObject Card18;
    public GameObject Card19;
    public GameObject Card20;
    public GameObject Card21;
    public GameObject Card22;
    public GameObject Card23;
    public GameObject Card24;
    public GameObject Card25;
    public GameObject Card26;
    public GameObject Card27;
    public GameObject Card28;
    public GameObject Card29;
    public GameObject Card30;
    public GameObject Card31;
    public GameObject Card32;
    public GameObject Card33;
    public GameObject Card34;
    public GameObject Card35;
    public GameObject Card36;
    public GameObject Card37;
    public GameObject Card38;
    public GameObject Card39;
    public GameObject Card40;
    public GameObject Card41;
    public GameObject Card42;
    public GameObject Card43;
    public GameObject Card44;
    public GameObject Card45;
    public GameObject Card46;
    public GameObject Card47;
    public GameObject Card48;
    public GameObject Card49;
    public GameObject Card50;
    public GameObject Card51;
    public GameObject Card52;


    //Useful game Objects
    public GameObject Button;
    public GameObject ButtonToStay;
    public GameObject ButtonToStart;
    public GameObject PriceSign;
    public GameObject BustText;
    public GameObject PlayerArea;
    public GameObject EnemyArea;
    public GameObject TempValues;


    //Random Values
    public bool round = false;
    public int index;
    public int playerTotal;
    public int bust = 22;
    public int tempPlayerTotal;
    public int tempPlayerTotal2;
    public int tempDealerTotal;
    public int dealerTotal;
    public int finalDealerTotal;
    public string score;




    //int the cardValue list the 1 values are card num 37-40
    int deckSize = 1;
    List<string> stringDeck = new List<string>();
    List<int> cardValue = new List<int>()
    { 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8,
      9, 9, 9, 9, 10, 10, 10, 10, 1, 1, 1, 1, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
      10,
    };
    List<GameObject> cards = new List<GameObject>();
    // Awake is called before the first frame update
    void Awake()
    {
        ButtonToStay.active = false;
        BustText.active = false;
        EnemyArea.active = false;


        for (int i = 0; i < deckSize; i++)
        {
            cards.Add(Card1);
            cards.Add(Card2);
            cards.Add(Card3);
            cards.Add(Card4);
            cards.Add(Card5);
            cards.Add(Card6);
            cards.Add(Card7);
            cards.Add(Card8);
            cards.Add(Card9);
            cards.Add(Card10);
            cards.Add(Card11);
            cards.Add(Card12);
            cards.Add(Card13);
            cards.Add(Card14);
            cards.Add(Card15);
            cards.Add(Card16);
            cards.Add(Card17);
            cards.Add(Card18);
            cards.Add(Card19);
            cards.Add(Card20);
            cards.Add(Card21);
            cards.Add(Card22);
            cards.Add(Card23);
            cards.Add(Card24);
            cards.Add(Card25);
            cards.Add(Card26);
            cards.Add(Card27);
            cards.Add(Card28);
            cards.Add(Card29);
            cards.Add(Card30);
            cards.Add(Card31);
            cards.Add(Card32);
            cards.Add(Card33);
            cards.Add(Card34);
            cards.Add(Card35);
            cards.Add(Card36);
            cards.Add(Card37);
            cards.Add(Card38);
            cards.Add(Card39);
            cards.Add(Card40);
            cards.Add(Card41);
            cards.Add(Card42);
            cards.Add(Card43);
            cards.Add(Card44);
            cards.Add(Card45);
            cards.Add(Card46);
            cards.Add(Card47);
            cards.Add(Card48);
            cards.Add(Card49);
            cards.Add(Card50);
            cards.Add(Card51);
            cards.Add(Card52);

        }

    }

    public void OnClick()
    {
            playerTotal = GamePacer(playerTotal);


        if (playerTotal > bust)
        {
            BustText.active = true;
            Button.active = false;

        }


    }

    public int GamePacer (int playerScore)
    {

            for (var i = 0; i < 2; i++)
            {
                // the value needed to draw a random card

                TempValues = cards[Random.Range(0, cards.Count)];


                //Getting the index of TempValues in the cards GameObject list
                index = cards.IndexOf(TempValues);

                // TempPlayerTotal is number at which the index is - Card.count before the TempValues is moved to the back of the deck.
                tempPlayerTotal = 0;
                tempPlayerTotal = index;
                playerTotal = cardValue[tempPlayerTotal];
                playerTotal = GetPlayerTotal(playerTotal);
                PlayerTotal.scoreValue = playerTotal;

                //Adding TempValues to the back of the deck.
                cards.Add(TempValues);

                // Putting the Cards on the table
                GameObject playerCard = Instantiate(cards[Random.Range(cards.Count - 1, cards.Count - 1)], new Vector3(0, 0, 0), Quaternion.identity);
                playerCard.transform.SetParent(PlayerArea.transform, false);

                //Removing cards from the back of the deck
                cards.RemoveAt(cards.Count - 1);
                cards.RemoveAt(cards.Count - 2);


                //Dealer 
                TempValues = cards[Random.Range(0, cards.Count)];
                tempDealerTotal = 0;
                tempDealerTotal = index;
                dealerTotal = cardValue[tempDealerTotal];
                dealerTotal = GetDealerTotal(dealerTotal);

                cards.Add(TempValues);
                GameObject enemyCard = Instantiate(cards[Random.Range(cards.Count - 1, cards.Count - 1)], new Vector3(0, 0, 0), Quaternion.identity);
                enemyCard.transform.SetParent(EnemyArea.transform, false);

                cards.RemoveAt(cards.Count - 1);
                cards.RemoveAt(cards.Count - 2);
                
            }
        return playerTotal;
        
    }

    public int GetPlayerTotal(int playerTotal)
    {
        tempPlayerTotal2 += playerTotal;

        if(tempPlayerTotal2 > 21)
        {
            BustText.active = true;
            Button.active = false;
            ButtonToStart.active = false;

        }
        return tempPlayerTotal2;   
    }
    public int GetDealerTotal(int dealerTotal)
    {
        finalDealerTotal += dealerTotal;
        return finalDealerTotal;
    }
}

