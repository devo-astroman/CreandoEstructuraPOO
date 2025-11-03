using UnityEngine;

public class PatineteLaser : MonoBehaviour
{
    public float VelocidadMax = 20f;
    public float Bateria = 100f;

    [SerializeField] private PatoPiloto _piloto;

    public PatoPiloto ObtenPiloto(){ 
        return _piloto;
    }
}