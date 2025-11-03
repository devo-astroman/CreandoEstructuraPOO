using UnityEngine;

public class PatoPiloto : MonoBehaviour
{
    public string Nombre;
    public float Energia = 100f;

    [SerializeField] private PatineteLaser _patinete;

    public PatineteLaser ObtenPatinete(){
        return _patinete;
    }

    public void MontarPatinete()
    {
        //Aquí debe montar el patinete
    }

    public void AcelerarPatinete()
    {
        //Acelera el patinete
    }

}
