//using UnityEngine;
//using UnityEngine.InputSystem;

//[RequireComponent(typeof(Rigidbody2D))]
//public class movement : MonoBehaviour
//{
//   public float walkSpeed = 5f;
//    public float runSpeed = 10f;

//    private float currentSpeed;

//    private Rigidbody2D rb2D;
//    private Vector2 Movement;

    //get rigid body on start of game
//    void Awake()
//    {
//       rb2D = GetComponent<Rigidbody2D>();
//        currentSpeed = walkSpeed;
//    }

    // Update is called once per frame
//    void Update()
//   {
//        rb2D.linearVelocity = Movement * currentSpeed;
//    }

//    public void Move(InputAction.CallbackContext ctx)
//    {
//        Movement = ctx.ReadValue<Vector2>();
//    }

//    public void Run(InputAction.CallbackContext ctx)
//    {
//        if (ctx.ReadValue<float>() == 1) // pressed
//        {
//           currentSpeed = runSpeed;
//        }
//        else // released
//        {
//            currentSpeed = walkSpeed;
//        }

//    }
//}
