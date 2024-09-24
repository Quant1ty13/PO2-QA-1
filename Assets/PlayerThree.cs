using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerThree : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Info;

    string Name = "Vergilius";
    int Health = 150;
    int Mana = 200;
    int ATK = 130;
    int MATK = 70;
    int DEF = 150;
    int MRES = 30;
    float SPD = 100.3f;

    public void ButtonPressed()
    {
        Info.text = "Details:\r\n \r\nName: " + Name + "\r\nHealth: " + Health + "\r\nMana: " + Mana + "\r\nATK: " + ATK + "\r\nM. ATK: " + MATK + "\r\nDEF: " + DEF + "\r\nM. RES: " + MRES + "\r\n SPD: " + SPD;
    }
}
