
public class Age
{
    private int age;

    public Age(int age)
    {
        ValidateAge(age);
        this.age = age;
        GetValue();
    }

    public int GetValue()
    {
        return age;
    }

    private void ValidateAge(int age)
    {
        if (age < 18 || age > 99)
        {
            throw new ArgumentException("Age must be between 18 and 99.");
        }
    }
}