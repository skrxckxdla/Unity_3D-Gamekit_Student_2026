using UnityEngine;
using FMOD.Studio;
using FMODUnity;

[CreateAssetMenu(fileName = "InteractablesAudio", menuName = "Scriptable Objects/InteractablesAudio")]
public class InteractablesAudio : ScriptableObject
{
    //Decalres a EventReference that references a specific event.
    [SerializeField] private EventReference pickupHealthAudio, boxDestroyAudio, switchAudio, doorAudio;

    //Declares a method that should play the pickupHealth sound without any 3D-positioning.
    public void PickUpHealthPlay()
    {
        RuntimeManager.PlayOneShot(pickupHealthAudio);
    }
}
