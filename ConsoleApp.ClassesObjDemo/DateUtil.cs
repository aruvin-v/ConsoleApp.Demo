internal static class DateUtil
{
    public static int YearOfBirth(int age)
    {
        if (age < 0) return 0;
        return DateTime.Now.Year - age;
    }
    public static int YearOfBirth(DateTime dateOfBirth)
    {
        if(dateOfBirth == null) return 0;
        return DateTime.Now.Year + dateOfBirth.Year;
    }
}
