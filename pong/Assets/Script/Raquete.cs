using UnityEngine;
using UnityEngine.InputSystem;

public class Raquete : MonoBehaviour
{


    [SerializeField] private InputActionReference moveAction;

    [SerializeField] private float speed = 5f; //Velocidade Raquete
    [SerializeField] private float limitY = 3.4f; //Limite raquete no eixo Y

    private float myY; //Y da raquete


    private void OnEnable()
    {
        moveAction.action.Enable();

    }


    private void OnDisable()
    {
        moveAction.action.Disable();

    }

    private void Start()
    {
        myY = transform.position.y; //Pegar posição Y

    }

    private void Update()
    {
        Vector2 input = moveAction.action.ReadValue<Vector2>();
        myY += input.y * speed * Time.deltaTime; //ganho
        myY = Mathf.Clamp(myY, -limitY, limitY); //limite

        //Movimentação
        Vector3 pos = transform.position; //pega posição atual
        pos.y = myY; //atribui a nova posição 
        transform.position = pos; //move a raquete


    }


}
