public static class InputProvider : MonoBehaviour
{
    public delegate void HaveShoot();
    public static event HaveShoot OnHasShoot;

    public delegate void HorizontalAxis(float value);
    public static event HorizontalAxis OnHorizontalAxis;

    public delegate void VerticalAxis(float value);
    public static event VerticalAxis OnVerticallAxis;

    public static void TriggerOnHasShoot() 
    {
        OnHasShoot?.Invoke();
    }

    public static void TriggerHorizontalAxis(float value) {
        OnhorizontalAxis?.Invoke(value);
    }

    public static void TriggerVerticalAxis(float value) {
        OnverticalAxis?.Invoke(value);  
    }
}
