using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject triggerCube;
    [SerializeField] private GameObject placeHolderSceneSwitch;

    private Interactable interactable;
    private bool switchScene = false;

    private void Awake ()
    {
        interactable = triggerCube.GetComponent<Interactable> ();
    }

    private void Update ()
    {
        if ( !switchScene && interactable.isHovering )
        {
            switchScene = true;
        }

        if ( switchScene )
        {
            placeHolderSceneSwitch.SetActive (true);
        }
    }
}
