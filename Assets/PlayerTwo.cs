using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Info;

    string Name = "Sgt. Johnson";
    int Health = 500;
    int Mana = 150;
    int ATK = 100;
    int MATK = 50;
    int DEF = 200;
    int MRES = 100;
    float SPD = 70.5f;

    public void ButtonPressed()
    {
        Info.text = "Details:\r\n \r\nName: " + Name + "\r\nHealth: " + Health + "\r\nMana: " + Mana + "\r\nATK: " + ATK + "\r\nM. ATK: " + MATK + "\r\nDEF: " + DEF + "\r\nM. RES: " + MRES + "\r\n SPD: " + SPD;
    }
}