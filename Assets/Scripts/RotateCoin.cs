using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    private int count = 0;
    void Update()
    {
        // (i bet there are better ways to do this
        // but i can't be bothered because i also have
        // another big assignment due tonight.)
        // purpose of this is to slow down the coin animation
        // a bit so it doesn't look like it's spinning too fast
        if (count % 3 == 0)
        {
            transform.Rotate(new Vector3(0f, 1f, 0f));
            count = -1;
        }

        count++;
    }
}
