using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM : MonoBehaviour
{
    public enum Season { Spring, Summer, Fall, Winter};
    public Season season = Season.Spring;

    public delegate void SeasonChangedHandler(Season season);
    public event SeasonChangedHandler SeasonChanged;

    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2f)
        {
            timer = 0f;
            ChangeSeason();
        }
    }

    void ChangeSeason()
    {
        switch (season)
        {
            case Season.Spring:
                season = Season.Summer;
                break;
            case Season.Summer:
                season = Season.Fall;
                break;
            case Season.Fall:
                season = Season.Winter;
                break;
            case Season.Winter:
                season = Season.Spring;
                break;
            default:
                break;
        }
        if (SeasonChanged != null)
        {
            SeasonChanged(season);
        }
    }
}
