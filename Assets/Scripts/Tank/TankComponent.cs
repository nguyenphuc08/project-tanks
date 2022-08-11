using UnityEngine;

public class TankComponent : MonoBehaviour {
    [SerializeField] private TankWeapon tankShooting;
    [SerializeField] private TankMovement tankMovement;
    [SerializeField] private TankHealth tankHealth;
    [SerializeField] private TankEffect tankEffect;
    [SerializeField] private TankWeapon tankWeapon;

    public TankWeapon TankShooting {get {return tankShooting;}}
    public TankMovement TankMovement {get {return tankMovement;}}
    public TankHealth TankHealth {get {return tankHealth;}}
    public TankEffect TankEffect {get {return tankEffect;}}
    public TankWeapon TankWeapon {get {return tankWeapon;}}

    public void OnStun(){
        tankShooting.enabled = false;
        tankMovement.enabled = false;
        TankWeapon.ResetWeapon();
    }
    public void OffStun(){
        tankShooting.enabled = true;
        tankMovement.enabled = true;
    }
    public void OffStunWithRoot(){
        tankShooting.enabled = true;
    }
}