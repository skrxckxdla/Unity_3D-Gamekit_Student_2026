using Gamekit3D;
using UnityEngine;

public class SurvivalMod : MonoBehaviour
{
    [SerializeField] private float thirstLevel = 100f;
    [SerializeField] private float thirstSpeed;
    [SerializeField] private float timer = 10;
    
    [SerializeField] private bool thirsty;
    [SerializeField] private bool parched;

    [SerializeField] private GameObject playerObject;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Subtracting the current value of thirstLevel with thirstSpeed. thirstSpeed is normalized
         by using Time.deltaTime, for an independent framerate. 
         Mathf.Clamp restricts the thirstLevel between its current max value and 0.
         */
        
        thirstLevel -= Mathf.Clamp(thirstSpeed * Time.deltaTime,0,thirstLevel);
        if (thirstLevel <= 50f && !thirsty) 
        {
            Debug.Log("getting thirsty...");
            thirsty = true;
            parched = true;
        }

        if (thirstLevel <= 0 && thirsty)
        {
            timer -= Time.deltaTime;
            if 
            
            Damageable.DamageMessage msg = new Damageable.DamageMessage()
            {
                amount = 1,
                damager = this,
                damageSource = new Vector3(),
                direction = new Vector3(),
                throwing = false,
                stopCamera = false
            };
            playerObject.GetComponent<Damageable>().ApplyDamage(msg);
            Debug.Log("Damage by thirst!");
            timer = 10f;
        }
    }
}
