using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerOne : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Info;

    string Name = "Kon";
    int Health = 150;
    int Mana = 100;
    int ATK = 20;
    int MATK = 80;
    int DEF = 30;
    int MRES = 50;
    float SPD = 45.5f;

    public void ButtonPressed()
    {
        Info.text = "Details:\r\n \r\nName: " + Name + "\r\nHealth: " + Health + "\r\nMana: " + Mana + "\r\nATK: " + ATK + "\r\nM. ATK: " + MATK + "\r\nDEF: " + DEF + "\r\nM. RES: " + MRES + "\r\n SPD: " + SPD;
    }
}
