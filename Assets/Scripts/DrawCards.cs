using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Button;
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
    public GameObject TempValues;

    public GameObject PlayerArea;
    public GameObject EnemyArea;

    int deckSize = 1;
    List<GameObject> cards = new List<GameObject>();


    void Start()
    {
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
        TempValues = cards[Random.Range(0, cards.Count)];
        cards.Add(TempValues);


        for (var i = 0; i < 2; i++)
        {
            GameObject playerCard = Instantiate(cards[Random.Range(cards.Count - 1, cards.Count - 1)], new Vector3(0, 0, 0), Quaternion.identity);
        playerCard.transform.SetParent(PlayerArea.transform, false);

            cards.RemoveAt(cards.Count - 1);

            cards.Remove(TempValues);


            /* GameObject enemyCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            enemyCard.transform.SetParent(EnemyArea.transform, false);
            */
        }

       // Button.active = false;
    }

 /*       cards.Add(Card1);
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
        */
}