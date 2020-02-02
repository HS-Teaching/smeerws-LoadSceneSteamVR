using UnityEngine;
using Valve.VR.InteractionSystem;

public class GameControllerMain : MonoBehaviour
{
    [SerializeField] private GameObject triggerCube;
    [SerializeField] private GameObject placeHolderSceneSwitch;

    private Interactable interactable;

    private int numberTaps;
    private const int numberTapsToSwitchScene = 2; 

    private void Awake ()
    {
        interactable = triggerCube.GetComponent<Interactable> ();
    }

    private void Start ()
    {
        ResetNumberTaps ();
    }

    public void OnHandHoverEnd ()
    {
        Debug.Log ("No Hand Hovering");
        numberTaps++;
    }

    private void SwitchScene ()
    {
        placeHolderSceneSwitch.SetActive (true);
    }

    private void ResetNumberTaps ()
    {
        numberTaps = 0;
    }

    private void Update ()
    {
        if ( numberTaps == numberTapsToSwitchScene )
        {
            ResetNumberTaps ();
            SwitchScene ();
        }
    }
}
