using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour {
    public static int mainScore=0;
    public static bool m1 = false;
    public static bool m2 = false;
    public static bool m3 = false;
    string statistic = "Echo";
    public Text txt;
    //void Start()
    //{
    //    //Moral();
    //    Invoke("FinishScore", 1);
    //}
    void Update() {
        if (m1 && m2 && m3 == true) {
            txt.text = "Вы красавчик ,прошли все безупречно. Общество вас любит";
        }
        if (m1 == true && m2 == true && m3 ==false)
        {
            txt.text = "Хорошо ! , не всем под силу укратить голубей!";
        }
        if (m2 == true && m3 == true && m1 == false)
        {
            txt.text = "Дворники не довольны вами , но бабушки даже очень !";
        }
        if (m1 == true && m3 == true && m2 == false)
        {
            txt.text = "Не те времена сынок ! , благо не бросаешь мусор мимо урн!";
        }
        if (m2 == false && m3 == false && m1 == true)
        {
            txt.text = "Вы обычный гражданин , хоть и не самый порядочный";
        }
        if (m1 == false && m3 == false && m2 == true)
        {
            txt.text = "Спасибо за таких внучков как ты !";
        }
        if (m1 == false && m2 == false && m3 == true)
        {
            txt.text = "А вы cпец в делах навозных =)";
        }
        if (m1 == false && m2 == false && m3 == false) {
            txt.text = "Вы провалили все испытания , может в другой раз повезет ?!";
        }
    }

    //void FinishScore() {
    //    txt.text = GetComponent<ScoreScript>().statistic;
    //}
    
}
