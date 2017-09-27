using UnityEngine;

public class GameDev : MonoBehaviour
{
    public FSM seasonFSM;

    void OnEnable()
    {
        seasonFSM.SeasonChanged += OnSeasonChanged;
        seasonFSM.SeasonChanged += Complain;
    }
    void OnDisable()
    {
        seasonFSM.SeasonChanged -= OnSeasonChanged;
        seasonFSM.SeasonChanged -= Complain;
    }

    void Complain(FSM.Season season)
    {
        if (season == FSM.Season.Winter)
        {
            Debug.Log("I hate snow!"); 
        }
    }

    public void OnSeasonChanged(FSM.Season season)
    {
        switch (season)
        {
            case FSM.Season.Spring:
                Debug.Log("Developing!");
                break;
            case FSM.Season.Summer:
                Debug.Log("Vacation!");
                break;
            case FSM.Season.Fall:
                Debug.Log("Buy coal...");
                break;
            case FSM.Season.Winter:
                Debug.Log("Brrrrrrrr!");
                break;
            default:
                break;
        }
    }
}
