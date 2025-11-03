using UnityEngine;

public class DonaTurbo : MonoBehaviour
{
    public string Sabor = "Chocolate";
    public float BonusVelocidad = 6f;

    [SerializeField] private bool _consumida = false;

    public bool EsConsumida(){
        return _consumida;
    }

}
