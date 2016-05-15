using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
    public static int mainScore=0;
    static bool m1;
    static bool m2;
    static bool m3;
    string statistic;
    void moral() {
        if (m1 && m2 && m3 == true) {
            statistic = "Вы красавчик ,прошли все безупречно. Общество вас любит";
        }
        if (m1 && m2 == true && m3 ==false)
        {
            statistic = "Хорошо ! , не всем под силу укратить голубей!";
        }
        if (m2 && m3 == true && m1 == false)
        {
            statistic = "Дворники не довольны вами , но бабушки даже очень !";
        }
        if (m1 && m3 == true && m2 == false)
        {
            statistic = "Не те времена сынок ! , благо не бросаешь мусор мимо урн!";
        }
        if (m2 && m3 == false && m1 == true)
        {
            statistic = "Вы обычный гражданин , хоть и не самый порядочный";
        }
        if (m1 && m3 == false && m2 == true)
        {
            statistic = "Спасибо за таких внучков как ты !";
        }
        if (m1 && m2 == false && m3 == true)
        {
            statistic = "А вы впец в делах навозных =)";
        }
    }
    void start() {
        Invoke("FinishScore",1);
    }
    void FinishScore() {

    }
}
